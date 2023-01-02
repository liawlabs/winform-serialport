namespace SerialPort
{
    partial class SerialConn
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
            this.components = new System.ComponentModel.Container();
            this.gb_COMPort = new System.Windows.Forms.GroupBox();
            this.lbl_connction_status = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.cb_com_port = new System.Windows.Forms.ComboBox();
            this.lblCOMPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gb_COMPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_COMPort
            // 
            this.gb_COMPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_COMPort.Controls.Add(this.lbl_connction_status);
            this.gb_COMPort.Controls.Add(this.btn_close);
            this.gb_COMPort.Controls.Add(this.btn_open);
            this.gb_COMPort.Controls.Add(this.cb_com_port);
            this.gb_COMPort.Controls.Add(this.lblCOMPort);
            this.gb_COMPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_COMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_COMPort.ForeColor = System.Drawing.Color.Black;
            this.gb_COMPort.Location = new System.Drawing.Point(96, 76);
            this.gb_COMPort.Name = "gb_COMPort";
            this.gb_COMPort.Size = new System.Drawing.Size(295, 289);
            this.gb_COMPort.TabIndex = 4;
            this.gb_COMPort.TabStop = false;
            this.gb_COMPort.Text = "Connection Settings";
            // 
            // lbl_connction_status
            // 
            this.lbl_connction_status.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_connction_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_connction_status.Location = new System.Drawing.Point(241, 98);
            this.lbl_connction_status.Name = "lbl_connction_status";
            this.lbl_connction_status.Size = new System.Drawing.Size(24, 22);
            this.lbl_connction_status.TabIndex = 13;
            this.lbl_connction_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Crimson;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(161, 235);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 35);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.White;
            this.btn_open.Location = new System.Drawing.Point(12, 235);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(120, 35);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // cb_com_port
            // 
            this.cb_com_port.FormattingEnabled = true;
            this.cb_com_port.Location = new System.Drawing.Point(11, 93);
            this.cb_com_port.Name = "cb_com_port";
            this.cb_com_port.Size = new System.Drawing.Size(183, 33);
            this.cb_com_port.TabIndex = 1;
            this.cb_com_port.DropDown += new System.EventHandler(this.cb_com_port_DropDown);
            // 
            // lblCOMPort
            // 
            this.lblCOMPort.AutoSize = true;
            this.lblCOMPort.ForeColor = System.Drawing.Color.Black;
            this.lblCOMPort.Location = new System.Drawing.Point(7, 57);
            this.lblCOMPort.Name = "lblCOMPort";
            this.lblCOMPort.Size = new System.Drawing.Size(147, 26);
            this.lblCOMPort.TabIndex = 0;
            this.lblCOMPort.Text = "COM PORT : ";
            // 
            // SerialConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.gb_COMPort);
            this.Name = "SerialConn";
            this.Text = "Serial Connection";
            this.Load += new System.EventHandler(this.SerialConn_Load);
            this.gb_COMPort.ResumeLayout(false);
            this.gb_COMPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_COMPort;
        private System.Windows.Forms.Label lbl_connction_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ComboBox cb_com_port;
        private System.Windows.Forms.Label lblCOMPort;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

