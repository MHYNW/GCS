namespace GCS_MH001
{
    partial class UC_gMap
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGmap = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelGmap
            // 
            this.panelGmap.Location = new System.Drawing.Point(1, 0);
            this.panelGmap.Name = "panelGmap";
            this.panelGmap.Size = new System.Drawing.Size(1810, 1132);
            this.panelGmap.TabIndex = 0;
            this.panelGmap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGmap_Paint);
            this.panelGmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapMouseClick);
            this.panelGmap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapMouseClick);
            // 
            // UC_gMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGmap);
            this.Name = "UC_gMap";
            this.Size = new System.Drawing.Size(1882, 1441);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGmap;
    }


}
