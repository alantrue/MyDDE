﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CsDDE_Simple_
{
    partial class DDEClientFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgConnection = new System.Windows.Forms.DataGridView();
            this.col_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_connect_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_remove_conn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_btn_add_item = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numVol = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelCurVol = new System.Windows.Forms.Label();
            this.labelCurPrice = new System.Windows.Forms.Label();
            this.numBoxDown = new System.Windows.Forms.NumericUpDown();
            this.numBoxUp = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.cbTimer = new System.Windows.Forms.CheckBox();
            this.numBigVolAlert = new System.Windows.Forms.NumericUpDown();
            this.numBigVol = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClearBuy = new System.Windows.Forms.Button();
            this.dgItemInfo = new System.Windows.Forms.DataGridView();
            this.col_iteminfo_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iteminfo_topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iteminfo_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_iteminfo_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBigBuy = new System.Windows.Forms.DataGridView();
            this.BuyVolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbBigSellCnt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbBigBuyCnt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbBigSub = new System.Windows.Forms.TextBox();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.tbAccBigSellPct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAccBigSell = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAccBigBuyPct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAccBigBuy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSellPct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBigPct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBigSell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBigBuy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAccSell = new System.Windows.Forms.TextBox();
            this.tbTotalSell = new System.Windows.Forms.TextBox();
            this.tbAccBuy = new System.Windows.Forms.TextBox();
            this.tbTotalBuy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgBigSell = new System.Windows.Forms.DataGridView();
            this.SellVolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgConnection)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBigVolAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBigVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBigBuy)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBigSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConnection
            // 
            this.dgConnection.AllowUserToAddRows = false;
            this.dgConnection.AllowUserToDeleteRows = false;
            this.dgConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service,
            this.col_topic,
            this.col_connect_status,
            this.col_remove_conn,
            this.col_btn_add_item});
            this.dgConnection.Location = new System.Drawing.Point(6, 21);
            this.dgConnection.MultiSelect = false;
            this.dgConnection.Name = "dgConnection";
            this.dgConnection.ReadOnly = true;
            this.dgConnection.RowHeadersVisible = false;
            this.dgConnection.RowTemplate.Height = 24;
            this.dgConnection.Size = new System.Drawing.Size(412, 50);
            this.dgConnection.TabIndex = 9;
            // 
            // col_service
            // 
            this.col_service.HeaderText = "Service";
            this.col_service.Name = "col_service";
            this.col_service.ReadOnly = true;
            // 
            // col_topic
            // 
            this.col_topic.HeaderText = "Topic";
            this.col_topic.Name = "col_topic";
            this.col_topic.ReadOnly = true;
            // 
            // col_connect_status
            // 
            this.col_connect_status.HeaderText = "連線狀態";
            this.col_connect_status.Name = "col_connect_status";
            this.col_connect_status.ReadOnly = true;
            // 
            // col_remove_conn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.col_remove_conn.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_remove_conn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.col_remove_conn.HeaderText = "";
            this.col_remove_conn.Name = "col_remove_conn";
            this.col_remove_conn.ReadOnly = true;
            this.col_remove_conn.Text = "移除";
            this.col_remove_conn.UseColumnTextForButtonValue = true;
            this.col_remove_conn.Width = 60;
            // 
            // col_btn_add_item
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.col_btn_add_item.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_btn_add_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.col_btn_add_item.HeaderText = "";
            this.col_btn_add_item.Name = "col_btn_add_item";
            this.col_btn_add_item.ReadOnly = true;
            this.col_btn_add_item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_btn_add_item.Text = "新增項目";
            this.col_btn_add_item.UseColumnTextForButtonValue = true;
            this.col_btn_add_item.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgConnection);
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 77);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DDE 連線資訊";
            this.groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numVol);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.labelCurVol);
            this.groupBox3.Controls.Add(this.labelCurPrice);
            this.groupBox3.Controls.Add(this.numBoxDown);
            this.groupBox3.Controls.Add(this.numBoxUp);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBoxName);
            this.groupBox3.Controls.Add(this.cbTimer);
            this.groupBox3.Controls.Add(this.numBigVolAlert);
            this.groupBox3.Controls.Add(this.numBigVol);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnClearBuy);
            this.groupBox3.Location = new System.Drawing.Point(6, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 141);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DDE 項目資訊";
            // 
            // numVol
            // 
            this.numVol.Location = new System.Drawing.Point(99, 80);
            this.numVol.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVol.Name = "numVol";
            this.numVol.Size = new System.Drawing.Size(55, 22);
            this.numVol.TabIndex = 23;
            this.numVol.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numVol.ValueChanged += new System.EventHandler(this.numVol_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(97, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 12);
            this.label21.TabIndex = 22;
            this.label21.Text = "量警示:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(97, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 12);
            this.label20.TabIndex = 21;
            this.label20.Text = "累積警示:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 12);
            this.label19.TabIndex = 20;
            this.label19.Text = "大單:";
            // 
            // labelCurVol
            // 
            this.labelCurVol.AutoSize = true;
            this.labelCurVol.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCurVol.Location = new System.Drawing.Point(247, 63);
            this.labelCurVol.Name = "labelCurVol";
            this.labelCurVol.Size = new System.Drawing.Size(92, 19);
            this.labelCurVol.TabIndex = 19;
            this.labelCurVol.Text = "cur volumn";
            // 
            // labelCurPrice
            // 
            this.labelCurPrice.AutoSize = true;
            this.labelCurPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCurPrice.Location = new System.Drawing.Point(169, 63);
            this.labelCurPrice.Name = "labelCurPrice";
            this.labelCurPrice.Size = new System.Drawing.Size(73, 19);
            this.labelCurPrice.TabIndex = 18;
            this.labelCurPrice.Text = "cur price";
            // 
            // numBoxDown
            // 
            this.numBoxDown.Location = new System.Drawing.Point(173, 111);
            this.numBoxDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBoxDown.Name = "numBoxDown";
            this.numBoxDown.Size = new System.Drawing.Size(60, 22);
            this.numBoxDown.TabIndex = 17;
            // 
            // numBoxUp
            // 
            this.numBoxUp.Location = new System.Drawing.Point(174, 30);
            this.numBoxUp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBoxUp.Name = "numBoxUp";
            this.numBoxUp.Size = new System.Drawing.Size(60, 22);
            this.numBoxUp.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(172, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 12);
            this.label18.TabIndex = 15;
            this.label18.Text = "箱型底:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(172, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 12);
            this.label17.TabIndex = 14;
            this.label17.Text = "箱型頂:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(7, 16);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(76, 22);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // cbTimer
            // 
            this.cbTimer.AutoSize = true;
            this.cbTimer.Location = new System.Drawing.Point(58, 117);
            this.cbTimer.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(15, 14);
            this.cbTimer.TabIndex = 12;
            this.cbTimer.UseVisualStyleBackColor = true;
            this.cbTimer.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numBigVolAlert
            // 
            this.numBigVolAlert.Location = new System.Drawing.Point(99, 30);
            this.numBigVolAlert.Margin = new System.Windows.Forms.Padding(2);
            this.numBigVolAlert.Name = "numBigVolAlert";
            this.numBigVolAlert.Size = new System.Drawing.Size(51, 22);
            this.numBigVolAlert.TabIndex = 11;
            this.numBigVolAlert.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numBigVolAlert.ValueChanged += new System.EventHandler(this.numBigVolAlert_ValueChanged);
            // 
            // numBigVol
            // 
            this.numBigVol.Location = new System.Drawing.Point(7, 83);
            this.numBigVol.Margin = new System.Windows.Forms.Padding(2);
            this.numBigVol.Name = "numBigVol";
            this.numBigVol.Size = new System.Drawing.Size(74, 22);
            this.numBigVol.TabIndex = 6;
            this.numBigVol.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBigVol.ValueChanged += new System.EventHandler(this.numBigVol_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 18);
            this.button1.TabIndex = 5;
            this.button1.Text = "連線";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearBuy
            // 
            this.btnClearBuy.Location = new System.Drawing.Point(7, 110);
            this.btnClearBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearBuy.Name = "btnClearBuy";
            this.btnClearBuy.Size = new System.Drawing.Size(47, 26);
            this.btnClearBuy.TabIndex = 10;
            this.btnClearBuy.Text = "清除";
            this.btnClearBuy.UseVisualStyleBackColor = true;
            this.btnClearBuy.Click += new System.EventHandler(this.btnClearBuy_Click);
            // 
            // dgItemInfo
            // 
            this.dgItemInfo.AllowUserToAddRows = false;
            this.dgItemInfo.AllowUserToDeleteRows = false;
            this.dgItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_iteminfo_service,
            this.col_iteminfo_topic,
            this.col_iteminfo_Item,
            this.col_iteminfo_value});
            this.dgItemInfo.Location = new System.Drawing.Point(422, 22);
            this.dgItemInfo.MultiSelect = false;
            this.dgItemInfo.Name = "dgItemInfo";
            this.dgItemInfo.ReadOnly = true;
            this.dgItemInfo.RowHeadersVisible = false;
            this.dgItemInfo.RowTemplate.Height = 24;
            this.dgItemInfo.Size = new System.Drawing.Size(301, 114);
            this.dgItemInfo.TabIndex = 0;
            this.dgItemInfo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemInfo_CellValueChanged);
            // 
            // col_iteminfo_service
            // 
            this.col_iteminfo_service.HeaderText = "Service";
            this.col_iteminfo_service.Name = "col_iteminfo_service";
            this.col_iteminfo_service.ReadOnly = true;
            // 
            // col_iteminfo_topic
            // 
            this.col_iteminfo_topic.HeaderText = "Topic";
            this.col_iteminfo_topic.Name = "col_iteminfo_topic";
            this.col_iteminfo_topic.ReadOnly = true;
            // 
            // col_iteminfo_Item
            // 
            this.col_iteminfo_Item.HeaderText = "Item";
            this.col_iteminfo_Item.Name = "col_iteminfo_Item";
            this.col_iteminfo_Item.ReadOnly = true;
            // 
            // col_iteminfo_value
            // 
            this.col_iteminfo_value.HeaderText = "Value";
            this.col_iteminfo_value.Name = "col_iteminfo_value";
            this.col_iteminfo_value.ReadOnly = true;
            // 
            // dgBigBuy
            // 
            this.dgBigBuy.AllowUserToAddRows = false;
            this.dgBigBuy.AllowUserToDeleteRows = false;
            this.dgBigBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBigBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyVolumn});
            this.dgBigBuy.Location = new System.Drawing.Point(6, 21);
            this.dgBigBuy.MultiSelect = false;
            this.dgBigBuy.Name = "dgBigBuy";
            this.dgBigBuy.ReadOnly = true;
            this.dgBigBuy.RowHeadersVisible = false;
            this.dgBigBuy.RowTemplate.Height = 24;
            this.dgBigBuy.Size = new System.Drawing.Size(48, 312);
            this.dgBigBuy.TabIndex = 0;
            // 
            // BuyVolumn
            // 
            this.BuyVolumn.FillWeight = 30F;
            this.BuyVolumn.HeaderText = "買量";
            this.BuyVolumn.Name = "BuyVolumn";
            this.BuyVolumn.ReadOnly = true;
            this.BuyVolumn.Width = 60;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbBigSellCnt);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tbBigBuyCnt);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbBigSub);
            this.groupBox4.Controls.Add(this.tbSub);
            this.groupBox4.Controls.Add(this.tbAccBigSellPct);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tbAccBigSell);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tbAccBigBuyPct);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbAccBigBuy);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbSellPct);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbBigPct);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbBigSell);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbBigBuy);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbAccSell);
            this.groupBox4.Controls.Add(this.tbTotalSell);
            this.groupBox4.Controls.Add(this.tbAccBuy);
            this.groupBox4.Controls.Add(this.tbTotalBuy);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dgBigSell);
            this.groupBox4.Controls.Add(this.dgBigBuy);
            this.groupBox4.Location = new System.Drawing.Point(6, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 339);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DDE 項目資訊";
            // 
            // tbBigSellCnt
            // 
            this.tbBigSellCnt.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbBigSellCnt.Location = new System.Drawing.Point(207, 197);
            this.tbBigSellCnt.Margin = new System.Windows.Forms.Padding(2);
            this.tbBigSellCnt.Name = "tbBigSellCnt";
            this.tbBigSellCnt.Size = new System.Drawing.Size(65, 22);
            this.tbBigSellCnt.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(205, 180);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "大賣盤次數";
            // 
            // tbBigBuyCnt
            // 
            this.tbBigBuyCnt.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbBigBuyCnt.Location = new System.Drawing.Point(63, 197);
            this.tbBigBuyCnt.Margin = new System.Windows.Forms.Padding(2);
            this.tbBigBuyCnt.Name = "tbBigBuyCnt";
            this.tbBigBuyCnt.Size = new System.Drawing.Size(65, 22);
            this.tbBigBuyCnt.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(61, 180);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 34;
            this.label15.Text = "大買盤次數";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(129, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 33;
            this.label14.Text = "大買賣差";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "買賣差";
            // 
            // tbBigSub
            // 
            this.tbBigSub.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbBigSub.ForeColor = System.Drawing.Color.Black;
            this.tbBigSub.Location = new System.Drawing.Point(131, 96);
            this.tbBigSub.Margin = new System.Windows.Forms.Padding(2);
            this.tbBigSub.Name = "tbBigSub";
            this.tbBigSub.Size = new System.Drawing.Size(72, 36);
            this.tbBigSub.TabIndex = 31;
            // 
            // tbSub
            // 
            this.tbSub.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSub.ForeColor = System.Drawing.Color.Black;
            this.tbSub.Location = new System.Drawing.Point(131, 42);
            this.tbSub.Margin = new System.Windows.Forms.Padding(2);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(72, 36);
            this.tbSub.TabIndex = 30;
            // 
            // tbAccBigSellPct
            // 
            this.tbAccBigSellPct.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAccBigSellPct.Location = new System.Drawing.Point(207, 153);
            this.tbAccBigSellPct.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccBigSellPct.Name = "tbAccBigSellPct";
            this.tbAccBigSellPct.Size = new System.Drawing.Size(64, 22);
            this.tbAccBigSellPct.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 136);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "大賣盤比例";
            // 
            // tbAccBigSell
            // 
            this.tbAccBigSell.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAccBigSell.ForeColor = System.Drawing.Color.Lime;
            this.tbAccBigSell.Location = new System.Drawing.Point(207, 96);
            this.tbAccBigSell.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccBigSell.Name = "tbAccBigSell";
            this.tbAccBigSell.Size = new System.Drawing.Size(64, 36);
            this.tbAccBigSell.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "累積大賣盤";
            // 
            // tbAccBigBuyPct
            // 
            this.tbAccBigBuyPct.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAccBigBuyPct.Location = new System.Drawing.Point(63, 153);
            this.tbAccBigBuyPct.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccBigBuyPct.Name = "tbAccBigBuyPct";
            this.tbAccBigBuyPct.Size = new System.Drawing.Size(65, 22);
            this.tbAccBigBuyPct.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "大買盤比例";
            // 
            // tbAccBigBuy
            // 
            this.tbAccBigBuy.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAccBigBuy.ForeColor = System.Drawing.Color.Red;
            this.tbAccBigBuy.Location = new System.Drawing.Point(63, 96);
            this.tbAccBigBuy.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccBigBuy.Name = "tbAccBigBuy";
            this.tbAccBigBuy.Size = new System.Drawing.Size(65, 36);
            this.tbAccBigBuy.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "累積大買盤";
            // 
            // tbSellPct
            // 
            this.tbSellPct.Location = new System.Drawing.Point(207, 313);
            this.tbSellPct.Margin = new System.Windows.Forms.Padding(2);
            this.tbSellPct.Name = "tbSellPct";
            this.tbSellPct.Size = new System.Drawing.Size(64, 22);
            this.tbSellPct.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "大賣盤比例";
            // 
            // tbBigPct
            // 
            this.tbBigPct.Location = new System.Drawing.Point(63, 312);
            this.tbBigPct.Margin = new System.Windows.Forms.Padding(2);
            this.tbBigPct.Name = "tbBigPct";
            this.tbBigPct.Size = new System.Drawing.Size(65, 22);
            this.tbBigPct.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "大買盤比例";
            // 
            // tbBigSell
            // 
            this.tbBigSell.Location = new System.Drawing.Point(207, 276);
            this.tbBigSell.Margin = new System.Windows.Forms.Padding(2);
            this.tbBigSell.Name = "tbBigSell";
            this.tbBigSell.Size = new System.Drawing.Size(64, 22);
            this.tbBigSell.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "總大賣盤";
            // 
            // tbBigBuy
            // 
            this.tbBigBuy.Location = new System.Drawing.Point(63, 276);
            this.tbBigBuy.Margin = new System.Windows.Forms.Padding(2);
            this.tbBigBuy.Name = "tbBigBuy";
            this.tbBigBuy.Size = new System.Drawing.Size(65, 22);
            this.tbBigBuy.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "總大買盤";
            // 
            // tbAccSell
            // 
            this.tbAccSell.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAccSell.ForeColor = System.Drawing.Color.Green;
            this.tbAccSell.Location = new System.Drawing.Point(207, 42);
            this.tbAccSell.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccSell.Name = "tbAccSell";
            this.tbAccSell.Size = new System.Drawing.Size(64, 36);
            this.tbAccSell.TabIndex = 9;
            // 
            // tbTotalSell
            // 
            this.tbTotalSell.Location = new System.Drawing.Point(207, 239);
            this.tbTotalSell.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalSell.Name = "tbTotalSell";
            this.tbTotalSell.Size = new System.Drawing.Size(64, 22);
            this.tbTotalSell.TabIndex = 8;
            // 
            // tbAccBuy
            // 
            this.tbAccBuy.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAccBuy.ForeColor = System.Drawing.Color.Maroon;
            this.tbAccBuy.Location = new System.Drawing.Point(63, 42);
            this.tbAccBuy.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccBuy.Name = "tbAccBuy";
            this.tbAccBuy.Size = new System.Drawing.Size(65, 36);
            this.tbAccBuy.TabIndex = 7;
            // 
            // tbTotalBuy
            // 
            this.tbTotalBuy.Location = new System.Drawing.Point(63, 239);
            this.tbTotalBuy.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalBuy.Name = "tbTotalBuy";
            this.tbTotalBuy.Size = new System.Drawing.Size(65, 22);
            this.tbTotalBuy.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "累積賣盤";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "總賣盤";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "累積買盤";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "總買盤";
            // 
            // dgBigSell
            // 
            this.dgBigSell.AllowUserToAddRows = false;
            this.dgBigSell.AllowUserToDeleteRows = false;
            this.dgBigSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBigSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellVolumn});
            this.dgBigSell.Location = new System.Drawing.Point(292, 21);
            this.dgBigSell.MultiSelect = false;
            this.dgBigSell.Name = "dgBigSell";
            this.dgBigSell.ReadOnly = true;
            this.dgBigSell.RowHeadersVisible = false;
            this.dgBigSell.RowTemplate.Height = 24;
            this.dgBigSell.Size = new System.Drawing.Size(47, 312);
            this.dgBigSell.TabIndex = 1;
            // 
            // SellVolumn
            // 
            this.SellVolumn.HeaderText = "賣量";
            this.SellVolumn.Name = "SellVolumn";
            this.SellVolumn.ReadOnly = true;
            this.SellVolumn.Width = 60;
            // 
            // dgTest
            // 
            this.dgTest.AllowUserToAddRows = false;
            this.dgTest.AllowUserToDeleteRows = false;
            this.dgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgTest.Location = new System.Drawing.Point(360, 169);
            this.dgTest.MultiSelect = false;
            this.dgTest.Name = "dgTest";
            this.dgTest.ReadOnly = true;
            this.dgTest.RowHeadersVisible = false;
            this.dgTest.RowTemplate.Height = 24;
            this.dgTest.Size = new System.Drawing.Size(50, 312);
            this.dgTest.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "未知";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // DDEClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 492);
            this.Controls.Add(this.dgItemInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgTest);
            this.Name = "DDEClientFrm";
            this.Text = "CSharp DDE Client Monitor";
            this.Load += new System.EventHandler(this.DDEClientFrm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DDEClientFrm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgConnection)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBigVolAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBigVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBigBuy)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBigSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgConnection;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn col_service;
        private DataGridViewTextBoxColumn col_topic;
        private DataGridViewTextBoxColumn col_connect_status;
        private DataGridViewButtonColumn col_remove_conn;
        private DataGridViewButtonColumn col_btn_add_item;
        private DataGridView dgItemInfo;
        private DataGridView dgBigBuy;
        private GroupBox groupBox4;
        private DataGridView dgBigSell;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox tbAccSell;
        private TextBox tbTotalSell;
        private TextBox tbAccBuy;
        private TextBox tbTotalBuy;
        private Label label3;
        private Label label4;
        private Button btnClearBuy;
        private NumericUpDown numBigVol;
        private DataGridViewTextBoxColumn col_iteminfo_service;
        private DataGridViewTextBoxColumn col_iteminfo_topic;
        private DataGridViewTextBoxColumn col_iteminfo_Item;
        private DataGridViewTextBoxColumn col_iteminfo_value;
        private DataGridView dgTest;
        private TextBox tbBigBuy;
        private Label label5;
        private TextBox tbBigSell;
        private Label label6;
        private TextBox tbSellPct;
        private Label label8;
        private TextBox tbBigPct;
        private Label label7;
        private TextBox tbAccBigSellPct;
        private Label label12;
        private TextBox tbAccBigSell;
        private Label label11;
        private TextBox tbAccBigBuyPct;
        private Label label10;
        private TextBox tbAccBigBuy;
        private Label label9;
        private DataGridViewTextBoxColumn BuyVolumn;
        private DataGridViewTextBoxColumn SellVolumn;
        private NumericUpDown numBigVolAlert;
        private CheckBox cbTimer;
        private TextBox tbBigSub;
        private TextBox tbSub;
        private Label label14;
        private Label label13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox textBoxName;
        private TextBox tbBigSellCnt;
        private Label label16;
        private TextBox tbBigBuyCnt;
        private Label label15;
        private Label label17;
        private NumericUpDown numBoxDown;
        private NumericUpDown numBoxUp;
        private Label label18;
        private Label labelCurPrice;
        private Label labelCurVol;
        private Label label19;
        private NumericUpDown numVol;
        private Label label21;
        private Label label20;

    }
}
