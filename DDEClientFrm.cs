using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

using NDde.Client;

namespace CsDDE_Simple_
{
    public partial class DDEClientFrm : Form
    {
        private Hashtable ht_conn;   //保存以 (連線字串) 為 key; 所建立的 DdeClient instance 為 object.
        private Hashtable ht_gdv;    // 保存以 (連線字串+項目名稱) 為 key;  DataGridViewRow 為 object.
        private Queue buyQueue = new Queue();
        private Queue sellQueue = new Queue();
        private Queue testQueue = new Queue();
        private Queue curPriceQueue = new Queue();
        private Queue curVolQueue = new Queue();
        private System.Windows.Forms.Timer myTimer;

        string TICK_VOLUMN;
        string BUY_PRICE;
        string SELL_PRICE;
        string CUR_PRICE;

        int curPrice = 0;
        int lastPrice = 0;

        int curVol = 0;
        int lastVol = 0;

        int totalBuy = 0;
        int totalSell = 0;

        int bigBuy = 0;
        int bigSell = 0;

        float buyPct = 0;
        float sellPct = 0;

        int accBuy = 0;
        int accSell = 0;

        int accBigBuy = 0;
        int accBigSell = 0;

        int bigBuyCnt = 0;
        int bigSellCnt = 0;

        float accBigBuyPct = 0;
        float accBigSellPct = 0;

        int BIG_VOL = 0;
        int ALERT_VOL = 0;
        int TIME_OUT = 60000;
        int ALERT_CUR_VOL = 0;

        delegate void AddDGCallback(int v);

        private volatile bool _shouldStop = false;
        
        public DDEClientFrm()
        {
            InitializeComponent();

            ht_conn = new Hashtable();
            ht_gdv   = new Hashtable();

            myTimer = new System.Windows.Forms.Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            Clear();
        }

        private void DDEClientFrm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = true;
        }

        private void AddConnection(String a_service, String a_topic)
        {            
           if (ht_conn.ContainsKey(a_service + "|" + a_topic))
           {
               MessageBox.Show("連線字串不能重覆！");
               return;
           }
           DdeClient dc = new DdeClient(a_service, a_topic);
           //register the event handler            
           dc.Disconnected += client_Disconnected;
           dc.Advise += client_Advise;
           try
           {  
                // Connect to the server.  It must be running or an exception will be thrown.
                dc.Connect();
                
                dgConnection.Rows.Add(a_service, a_topic, "已連線");

               //利用 "service|topic" 為 HashTable 的 Key; DdeClient 為 Object.
                string key = a_service + "|" + a_topic;
                ht_conn.Add(key, dc); 
            }
            catch (Exception thrown)
            {
               MessageBox.Show("無法連結 DDE Server：" + thrown.Message);
            }
        }

        private void AddConnectionItem(String a_service, String a_topic, String a_item)
        {
            //取得該列的連線字串, 並以該字串為 key, 找出對應的 DdeClient instance.
            string key = a_service + "|" + a_topic;
            DdeClient dc = (DdeClient)ht_conn[key];
            string item = a_item;

            this.AddItem(dc, item);    //新增 Item
        }

        private int GetBuyPrice()
        {
            return GetValue(BUY_PRICE);
        }

        private int GetSellPrice()
        {
            return GetValue(SELL_PRICE);
        }

        private int GetCurPrice()
        {
            return GetValue(CUR_PRICE);
        }

        private int GetTickVol()
        {
            return GetValue(TICK_VOLUMN);
        }

        private int GetValue(string a_key)
        {
            //取得 key 所對應位置的 DataGridViewRow
            DataGridViewRow chg_value_row = (DataGridViewRow)ht_gdv[a_key];
            try
            {
                return Convert.ToInt32(chg_value_row.Cells["col_iteminfo_value"].Value.ToString());
            }
            catch (System.Exception)
            {
                return 0;
            }
        }

        private void AddBigSell(int a_vol)
        {
            if (dgBigSell.InvokeRequired)
            {
                AddDGCallback d = new AddDGCallback(AddBigSell);
                Invoke(d, new object[] { a_vol });
            }
            else
            {
                totalSell += a_vol;
                tbTotalSell.Text = totalSell.ToString();

                accSell += a_vol;
                tbAccSell.Text = accSell.ToString();

                RefreshSub();

                if (a_vol >= BIG_VOL)
                {
                    bigSell += a_vol;
                    tbBigSell.Text = bigSell.ToString();

                    int oldBigSell = accBigSell;
                    accBigSell += a_vol;
                    tbAccBigSell.Text = accBigSell.ToString();

                    RefreshBigSub();

                    if (oldBigSell / ALERT_VOL != accBigSell / ALERT_VOL)
                    {
                        SystemSounds.Beep.Play();
                        bigSellCnt += 1;
                        tbBigSellCnt.Text = bigSellCnt.ToString();
                    }

                    dgBigSell.Rows.Insert(0, a_vol.ToString());
                    dgBigSell.Rows[0].Cells[0].Selected = true;
                }

                if (totalSell > 0)
                {
                    sellPct = bigSell * 100 / totalSell;
                    tbSellPct.Text = sellPct.ToString();
                }

                if (accSell > 0)
                {
                    accBigSellPct = accBigSell * 100 / accSell;
                    tbAccBigSellPct.Text = accBigSellPct.ToString();
                }
            }
        }

        private void RefreshSub()
        {
            int sub = accBuy - accSell;
            tbSub.Text = sub.ToString();
        }

        private void RefreshBigSub()
        {
            int bigSub = accBigBuy - accBigSell;
            tbBigSub.Text = bigSub.ToString();
        }

        private void AddBigBuy(int a_vol)
        {
            if (dgBigBuy.InvokeRequired)
            {
                AddDGCallback d = new AddDGCallback(AddBigBuy);
                Invoke(d, new object[] { a_vol });
            }
            else
            {
                totalBuy += a_vol;
                tbTotalBuy.Text = totalBuy.ToString();

                accBuy += a_vol;
                tbAccBuy.Text = accBuy.ToString();

                RefreshSub();

                if (a_vol >= BIG_VOL)
                {
                    bigBuy += a_vol;
                    tbBigBuy.Text = bigBuy.ToString();
                    
                    int oldBigBuy = accBigBuy;
                    accBigBuy += a_vol;
                    tbAccBigBuy.Text = accBigBuy.ToString();

                    RefreshBigSub();

                    if (oldBigBuy / ALERT_VOL != accBigBuy / ALERT_VOL)
                    {
                        SystemSounds.Asterisk.Play();
                        bigBuyCnt += 1;
                        tbBigBuyCnt.Text = bigBuyCnt.ToString();
                    }

                    dgBigBuy.Rows.Insert(0, a_vol.ToString());
                    dgBigBuy.Rows[0].Cells[0].Selected = true;
                }

                buyPct = bigBuy * 100 / totalBuy;
                tbBigPct.Text = buyPct.ToString();

                accBigBuyPct = accBigBuy * 100 / accBuy;
                tbAccBigBuyPct.Text = accBigBuyPct.ToString();
            }
        }

        private void AddTest(int a_vol)
        {
            if (dgTest.InvokeRequired)
            {
                AddDGCallback d = new AddDGCallback(AddTest);
                Invoke(d, new object[] { a_vol });
            }
            else
            {
                dgTest.Rows.Insert(0, a_vol.ToString());
                dgTest.Rows[0].Cells[0].Selected = true;
            }
        }

        private void ShowCurPrice(int a_price)
        {
            if (labelCurPrice.InvokeRequired)
            {
                AddDGCallback d = new AddDGCallback(ShowCurPrice);
                Invoke(d, new object[] { a_price });
            }
            else
            {
                lastPrice = curPrice;
                curPrice = a_price;

                labelCurPrice.Text = a_price.ToString();

                if (lastPrice <= numBoxUp.Value &&
                curPrice > numBoxUp.Value)
                {
                    SystemSounds.Exclamation.Play();
                }

                if (lastPrice >= numBoxDown.Value &&
                    curPrice < numBoxDown.Value)
                {
                    SystemSounds.Hand.Play();
                }
            }
        }

        private void ShowCurVolumn(int a_vol)
        {
            if (labelCurVol.InvokeRequired)
            {
                AddDGCallback d = new AddDGCallback(ShowCurVolumn);
                Invoke(d, new object[] { a_vol });
            }
            else
            {
                lastVol = curVol;
                curVol += a_vol;

                labelCurVol.Text = curVol.ToString();

                if (lastVol / ALERT_CUR_VOL != curVol / ALERT_CUR_VOL)
                {
                    SystemSounds.Hand.Play();
                }
            }
        }

        private void TickVolCheck()
        {
            int tickVol = GetTickVol();
            int curPrice = GetCurPrice();
            int buyPrice = GetBuyPrice();
            int sellPrice = GetSellPrice();

            curPriceQueue.Enqueue(curPrice);
            curVolQueue.Enqueue(tickVol);

            if (curPrice <= buyPrice)
            {
                sellQueue.Enqueue(tickVol);
            }
            else if (curPrice >= sellPrice)
            {
                buyQueue.Enqueue(tickVol);
            }
            else
            {
                testQueue.Enqueue(tickVol);
            }
        }

        private void UpdateQueue()
        {
            while (!_shouldStop)
            {
                if (buyQueue.Count > 0)
                {
                    int vol = (int)buyQueue.Dequeue();
                    AddBigBuy(vol);
                }

                if (sellQueue.Count > 0)
                {
                    int vol = (int)sellQueue.Dequeue();
                    AddBigSell(vol);
                }

                if (testQueue.Count > 0)
                {
                    int vol = (int)testQueue.Dequeue();
                    AddTest(vol);
                }

                if (curPriceQueue.Count > 0)
                {
                    int curPrice = (int)curPriceQueue.Dequeue();
                    ShowCurPrice(curPrice);
                }

                if (curVolQueue.Count > 0)
                {
                    int curVolumn = (int)curVolQueue.Dequeue();
                    ShowCurVolumn(curVolumn);
                }
            }
        }

        /** 新增項目(Item), 並取得該項目的值(Value)
         *   1. 呼叫 DdeClient 的 "Request()" & "StartAdvise" 取得該 Item 的值
         *   2. 利用 service|topic!item 字串為 key
         *   2.1 ht_gdv(HashTable) -> (key, DataGridViewRow)
         *   3. 在 dgItemInfo(DataGridView)新增一列, 顯示項目相關資訊
         *   
         *   <param name="dc">     "新增項目" 按鈕事件所在列對應的 DdeClient
         *   <param name="item"> "新增項目" 名稱(Name)
         */
        private void AddItem(DdeClient dc, string item)
        {
            try
            {
                string key = dc.Service + "|" + dc.Topic + "!" + item;

                Item it = new Item();
                it.item = item; it.value = "";

                try
                {
                    //Synchronous Request Operation, 用以取得第一次呼叫的值
                    //eLeader, 康和 並未支援同步呼叫; yeswin/hts 則有支援
                    byte[] data = dc.Request(item, 1, 60000);
                    int codepage = Encoding.Default.CodePage;   //取得編碼的 codpage. 中文 Default: 950
                    string value = Encoding.GetEncoding(codepage).GetString(data, 0, data.Length);
                    //it.value = Encoding.ASCII.GetString(data);
                    it.value = value;
                }
                catch (Exception )
                {                    
                    ;  //忽略該錯誤
                }

                //Add a Row
                int idx = dgItemInfo.Rows.Add(dc.Service, dc.Topic, item, it.value);
                //保存 key 與 所在新增 Row
                ht_gdv.Add(key, dgItemInfo.Rows[idx]);

                // Advise Loop
                dc.StartAdvise(item, 1, true, 60000);
            }
            catch (Exception thrown)
            {
                MessageBox.Show("無法新增項目： \n" + thrown.Message);
            }
        }

        /** 移除所在連線資訊列(row)相關連線資訊與所關聯的項目(item)資訊
         *    <param = row_idx> dgView1 移除按鈕事件所在列的位置
         */
        private void Remove_Connect_and_Item_Row(int row_idx)
        {
            /** 確定為 "移除按鈕" 後的處理
            *   1. 刪除 HashTable 內的 key/value, 以及 DdeClient instance
            *   2. 將該列(row)從 dgConnection(DataGridView) 移除。
            */

            //取得移除按鈕按下時所在的列(row)
            DataGridViewRow del_row = dgConnection.Rows[row_idx];
            //取得刪除列的欄位(col_service, col_topic)值當成 key, 以取出所對應的 DdeClient 連線 instance.
            string key = del_row.Cells["col_service"].Value.ToString() + "|" + del_row.Cells["col_topic"].Value.ToString();
            DdeClient client_conn = (DdeClient)ht_conn[key];

            //利用 連線字串(service+topic) 為 key, 刪除相關聯(1到多) dgItemInfo 所在的 Item 列
            ArrayList list = new ArrayList();  //暫存欲刪除的 Item Key.
            foreach (DictionaryEntry de1 in ht_gdv)
            {
                //取出 "!" 前面的字串 (service|topic)
                string item_key = de1.Key.ToString();
                string item_key_substr = item_key.Substring(0, item_key.IndexOf("!"));

                //每一個欲刪除的 Item, 需先呼叫 DdeClient.StopAdvise
                if (key.Equals(item_key_substr))
                {
                    DataGridViewRow del_item_row = (DataGridViewRow)de1.Value;
                    string item = del_item_row.Cells["col_iteminfo_Item"].Value.ToString();
                    this.Stop_advise(client_conn, item);
                    list.Add(item_key);  
                }
            }

            //實際刪除 Item 所在的 DataGridView Row, 以及移除儲存在 HashTable 的 key/value
            foreach (string str_key in list)
            {
                DataGridViewRow del_item_row = (DataGridViewRow)ht_gdv[str_key];
                ht_gdv.Remove(str_key);
                dgItemInfo.Rows.Remove(del_item_row);
            }

            //刪除所儲存連線資訊的 key/value, 以及將該 DdeClient 連線移除。
            ht_conn.Remove(key);
            client_conn.Dispose();

            //將所在的連線資料列刪除掉
            dgConnection.Rows.RemoveAt(row_idx);
        }

        //Stop Advise
        private void Stop_advise(DdeClient dc, string item)
        {
            try
            {
                dc.StopAdvise(item, 60000);
            }
            catch (Exception thrown)
            {
                MessageBox.Show("Can not Stop Advise: \n" + thrown.Message);
            }
        }

        private void client_Advise(object sender, DdeAdviseEventArgs args)
        {
            DdeClient dc = (DdeClient)sender;
            string key = dc.Service + "|" + dc.Topic + "!" + args.Item;
            //取得 key 所對應位置的 DataGridViewRow
            DataGridViewRow chg_value_row = (DataGridViewRow)ht_gdv[key];
            
            //將變動的值指定至該列所在的欄位 "Item_Value"
            int codepage = Encoding.Default.CodePage;   //取得編碼的 codpage. 中文 Default: 950
            char[] spliter = { '.', '\0' };
            string data = Encoding.GetEncoding(codepage).GetString(args.Data, 0, args.Data.Length).Split(spliter)[0];

            //顯示變動後的 Item 值.
            chg_value_row.Cells["col_iteminfo_value"].Value = data;
        }

        private void client_Disconnected(object sender, DdeDisconnectedEventArgs args)
        {
            string msg =
                "OnDisconnected: " +
                "IsServerInitiated=" + args.IsServerInitiated.ToString() + " " +
                "IsDisposed=" + args.IsDisposed.ToString();
            //可實做將該訊息顯示在 StatusBar 上.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTotalSell.Text = "0";
            tbAccSell.Text = "0";
            tbTotalBuy.Text = "0";
            tbAccBuy.Text = "0";

            BIG_VOL = Convert.ToInt32(numBigVol.Value);
            ALERT_VOL = Convert.ToInt32(numBigVolAlert.Value);
            ALERT_CUR_VOL = Convert.ToInt32(numVol.Value);

            AddConnection("CATDDE", String.Format("FUTOPT<FO>{0}     ", textBoxName.Text.TrimEnd()));
            AddConnectionItem("CATDDE", String.Format("FUTOPT<FO>{0}     ", textBoxName.Text.TrimEnd()), "CurPrice");
            AddConnectionItem("CATDDE", String.Format("FUTOPT<FO>{0}     ", textBoxName.Text.TrimEnd()), "BuyPrice1");
            AddConnectionItem("CATDDE", String.Format("FUTOPT<FO>{0}     ", textBoxName.Text.TrimEnd()), "SellPrice1");
            AddConnectionItem("CATDDE", String.Format("FUTOPT<FO>{0}     ", textBoxName.Text.TrimEnd()), "TickVol");

            ThreadStart myRun = new ThreadStart(UpdateQueue);
		    Thread myThread = new Thread(myRun);
		    myThread.Start();
        }

        private void btnClearBuy_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            lastVol = 0;
            curVol = 0;
            labelCurVol.Text = curVol.ToString();

            String buy = String.Format("{0}", accBuy);
            String sell = String.Format("{0}", accSell);

            String bigBuy = String.Format("{0}", accBigBuy);
            String bigSell = String.Format("{0}", accBigSell);

            string datePatt = @"hh:mm";
            string dtString = DateTime.Now.ToString(datePatt);

            dgList.Rows.Insert(0, dtString, buy, sell, bigBuy, bigSell);

            accBuy = 0;
            tbAccBuy.Text = accBuy.ToString();

            accBigBuy = 0;
            tbAccBigBuy.Text = accBigBuy.ToString();

            accBigBuyPct = 0;
            tbAccBigBuyPct.Text = accBigBuyPct.ToString();

            dgBigBuy.Rows.Clear();
            
            accSell = 0;
            tbAccSell.Text = accSell.ToString();

            accBigSell = 0;
            tbAccBigSell.Text = accBigSell.ToString();

            accBigSellPct = 0;
            tbAccBigSellPct.Text = accBigSellPct.ToString();

            dgBigSell.Rows.Clear();

            RefreshSub();
            RefreshBigSub();

            dgTest.Rows.Clear();
        }

        private void numBigVol_ValueChanged(object sender, EventArgs e)
        {
            BIG_VOL = Convert.ToInt32(numBigVol.Value);
        }

        private void dgItemInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {            
            if (ht_gdv == null)
            {
                return;
            }

            DataGridViewRow tickRow = (DataGridViewRow)ht_gdv[TICK_VOLUMN];
            if (tickRow == null)
            {
                return;
            }
            
            if (e.RowIndex == tickRow.Index)
            {
                TickVolCheck();
            }
        }

        private void numBigVolAlert_ValueChanged(object sender, EventArgs e)
        {
            ALERT_VOL = Convert.ToInt32(numBigVolAlert.Value);
        }

        private void numVol_ValueChanged(object sender, EventArgs e)
        {
            ALERT_CUR_VOL = Convert.ToInt32(numVol.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimer.Checked)
            {
                myTimer.Interval = TIME_OUT;
                myTimer.Start();
            }
            else
            {
                myTimer.Stop();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            TICK_VOLUMN = String.Format("CATDDE|FUTOPT<FO>{0}     !TickVol", textBoxName.Text.TrimEnd());
            BUY_PRICE = String.Format("CATDDE|FUTOPT<FO>{0}     !BuyPrice1", textBoxName.Text.TrimEnd());
            SELL_PRICE = String.Format("CATDDE|FUTOPT<FO>{0}     !SellPrice1", textBoxName.Text.TrimEnd());
            CUR_PRICE = String.Format("CATDDE|FUTOPT<FO>{0}     !CurPrice", textBoxName.Text.TrimEnd());
        }

        private void DDEClientFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _shouldStop = true;
        }

        private void dgList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }

            int otherIndex = (e.ColumnIndex % 2 > 0) ? e.ColumnIndex + 1 : e.ColumnIndex - 1;

            int a = Convert.ToInt32(dgList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            int b = Convert.ToInt32(dgList.Rows[e.RowIndex].Cells[otherIndex].Value);

            if (a > b)
            {
                dgList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Khaki;
            }
            else if (a < b)
            {
                dgList.Rows[e.RowIndex].Cells[otherIndex].Style.BackColor = Color.Khaki;
            }
        }

        private void dgList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgUpdate(3, dgList1);
            dgUpdate(5, dgList2);
            dgUpdate(15, dgList3);
            dgUpdate(30, dgList4);
        }

        private void dgUpdate(int count, DataGridView a_dg)
        {
            if (DateTime.Now.Minute % count == 0)
            {
                if (dgList.Rows.Count >= count)
                {
                    int buy = 0;
                    int sell = 0;

                    for (int i = 0; i < count; ++i)
                    {
                        buy += Convert.ToInt32(dgList.Rows[i].Cells[1].Value);
                        sell += Convert.ToInt32(dgList.Rows[i].Cells[2].Value);
                    }

                    string datePatt = @"hh:mm";
                    string dtString = DateTime.Now.ToString(datePatt);

                    a_dg.Rows.Insert(0, dtString, buy, sell);
                }
            }
        }
    }
}
