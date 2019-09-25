namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.scorebox = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.TopBackGround = new System.Windows.Forms.PictureBox();
            this.Board = new System.Windows.Forms.PictureBox();
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.BackBoard = new System.Windows.Forms.PictureBox();
            this.backlabel = new System.Windows.Forms.Label();
            this.modelabel = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.Label();
            this.resetmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // scorebox
            // 
            this.scorebox.AutoSize = true;
            this.scorebox.Font = new System.Drawing.Font("굴림", 28F);
            this.scorebox.Location = new System.Drawing.Point(33, 23);
            this.scorebox.Name = "scorebox";
            this.scorebox.Size = new System.Drawing.Size(123, 38);
            this.scorebox.TabIndex = 2;
            this.scorebox.Text = "label1";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(378, 187);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(38, 12);
            this.message.TabIndex = 3;
            this.message.Tag = "message";
            this.message.Text = "label1";
            // 
            // TopBackGround
            // 
            this.TopBackGround.Image = global::WindowsFormsApp1.Properties.Resources.TopBackGround;
            this.TopBackGround.Location = new System.Drawing.Point(-2, -10);
            this.TopBackGround.Name = "TopBackGround";
            this.TopBackGround.Size = new System.Drawing.Size(804, 30);
            this.TopBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TopBackGround.TabIndex = 4;
            this.TopBackGround.TabStop = false;
            // 
            // Board
            // 
            this.Board.Image = global::WindowsFormsApp1.Properties.Resources.Board;
            this.Board.Location = new System.Drawing.Point(386, 397);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(58, 11);
            this.Board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Board.TabIndex = 1;
            this.Board.TabStop = false;
            this.Board.Tag = "board";
            // 
            // BackGround
            // 
            this.BackGround.Image = global::WindowsFormsApp1.Properties.Resources.BackGround;
            this.BackGround.Location = new System.Drawing.Point(-2, -10);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(804, 500);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackGround.TabIndex = 0;
            this.BackGround.TabStop = false;
            // 
            // BackBoard
            // 
            this.BackBoard.Image = global::WindowsFormsApp1.Properties.Resources.BackBoard;
            this.BackBoard.Location = new System.Drawing.Point(386, 62);
            this.BackBoard.Name = "BackBoard";
            this.BackBoard.Size = new System.Drawing.Size(58, 11);
            this.BackBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackBoard.TabIndex = 5;
            this.BackBoard.TabStop = false;
            this.BackBoard.Tag = "board";
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.Location = new System.Drawing.Point(665, 62);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(65, 12);
            this.backlabel.TabIndex = 6;
            this.backlabel.Text = "> 돌아가기";
            // 
            // modelabel
            // 
            this.modelabel.AutoSize = true;
            this.modelabel.Location = new System.Drawing.Point(665, 84);
            this.modelabel.Name = "modelabel";
            this.modelabel.Size = new System.Drawing.Size(37, 12);
            this.modelabel.TabIndex = 7;
            this.modelabel.Text = "  모드";
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.Location = new System.Drawing.Point(665, 110);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(37, 12);
            this.mode.TabIndex = 8;
            this.mode.Text = "  쉬움";
            // 
            // resetmessage
            // 
            this.resetmessage.AutoSize = true;
            this.resetmessage.Location = new System.Drawing.Point(378, 212);
            this.resetmessage.Name = "resetmessage";
            this.resetmessage.Size = new System.Drawing.Size(38, 12);
            this.resetmessage.TabIndex = 9;
            this.resetmessage.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetmessage);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.modelabel);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.BackBoard);
            this.Controls.Add(this.TopBackGround);
            this.Controls.Add(this.message);
            this.Controls.Add(this.scorebox);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.BackGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpKey);
            ((System.ComponentModel.ISupportInitialize)(this.TopBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.Label scorebox;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox TopBackGround;
        private System.Windows.Forms.PictureBox BackBoard;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Label modelabel;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.Label resetmessage;
    }
}

