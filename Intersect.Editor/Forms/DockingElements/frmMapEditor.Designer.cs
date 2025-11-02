using DarkUI.Controls;
using Intersect.Editor.Forms.Controls;

namespace Intersect.Editor.Forms.DockingElements
{
    partial class FrmMapEditor
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
            this.pnlFloorControls = new System.Windows.Forms.Panel();
            this.lblMultiFloorHint = new System.Windows.Forms.Label();
            this.btnFloorDown = new DarkUI.Controls.DarkButton();
            this.btnFloorUp = new DarkUI.Controls.DarkButton();
            this.nudFloorLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.lblFloorHeader = new System.Windows.Forms.Label();
            this.pnlMapContainer = new System.Windows.Forms.Panel();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.tooltipMapAttribute = new MapAttributeTooltip();
            this.pnlFloorControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloorLevel)).BeginInit();
            this.pnlMapContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFloorControls
            //
            this.pnlFloorControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFloorControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlFloorControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFloorControls.Controls.Add(this.lblMultiFloorHint);
            this.pnlFloorControls.Controls.Add(this.btnFloorDown);
            this.pnlFloorControls.Controls.Add(this.btnFloorUp);
            this.pnlFloorControls.Controls.Add(this.nudFloorLevel);
            this.pnlFloorControls.Controls.Add(this.lblFloorHeader);
            this.pnlFloorControls.Location = new System.Drawing.Point(44, 8);
            this.pnlFloorControls.Name = "pnlFloorControls";
            this.pnlFloorControls.Size = new System.Drawing.Size(148, 70);
            this.pnlFloorControls.TabIndex = 3;
            this.pnlFloorControls.Visible = false;
            //
            // lblMultiFloorHint
            //
            this.lblMultiFloorHint.AutoSize = true;
            this.lblMultiFloorHint.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMultiFloorHint.Location = new System.Drawing.Point(6, 6);
            this.lblMultiFloorHint.MaximumSize = new System.Drawing.Size(130, 0);
            this.lblMultiFloorHint.Name = "lblMultiFloorHint";
            this.lblMultiFloorHint.Size = new System.Drawing.Size(35, 13);
            this.lblMultiFloorHint.TabIndex = 4;
            this.lblMultiFloorHint.Text = "label1";
            this.lblMultiFloorHint.Visible = false;
            //
            // btnFloorDown
            //
            this.btnFloorDown.Location = new System.Drawing.Point(77, 39);
            this.btnFloorDown.Name = "btnFloorDown";
            this.btnFloorDown.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnFloorDown.Size = new System.Drawing.Size(64, 23);
            this.btnFloorDown.TabIndex = 3;
            this.btnFloorDown.Text = "-";
            this.btnFloorDown.Click += new System.EventHandler(this.btnFloorDown_Click);
            //
            // btnFloorUp
            //
            this.btnFloorUp.Location = new System.Drawing.Point(7, 39);
            this.btnFloorUp.Name = "btnFloorUp";
            this.btnFloorUp.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnFloorUp.Size = new System.Drawing.Size(64, 23);
            this.btnFloorUp.TabIndex = 2;
            this.btnFloorUp.Text = "+";
            this.btnFloorUp.Click += new System.EventHandler(this.btnFloorUp_Click);
            //
            // nudFloorLevel
            //
            this.nudFloorLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFloorLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFloorLevel.Location = new System.Drawing.Point(7, 19);
            this.nudFloorLevel.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudFloorLevel.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.nudFloorLevel.Name = "nudFloorLevel";
            this.nudFloorLevel.Size = new System.Drawing.Size(134, 20);
            this.nudFloorLevel.TabIndex = 1;
            this.nudFloorLevel.ValueChanged += new System.EventHandler(this.nudFloorLevel_ValueChanged);
            //
            // lblFloorHeader
            //
            this.lblFloorHeader.AutoSize = true;
            this.lblFloorHeader.Location = new System.Drawing.Point(4, 4);
            this.lblFloorHeader.Name = "lblFloorHeader";
            this.lblFloorHeader.Size = new System.Drawing.Size(30, 13);
            this.lblFloorHeader.TabIndex = 0;
            this.lblFloorHeader.Text = "Floor";
            //
            // pnlMapContainer
            //
            this.pnlMapContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMapContainer.AutoScroll = true;
            this.pnlMapContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlMapContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMapContainer.Controls.Add(this.picMap);
            this.pnlMapContainer.Controls.Add(this.pnlFloorControls);
            this.pnlMapContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMapContainer.Name = "pnlMapContainer";
            this.pnlMapContainer.Size = new System.Drawing.Size(204, 101);
            this.pnlMapContainer.TabIndex = 1;
            this.pnlMapContainer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlMapContainer_Scroll);
            this.pnlMapContainer.Resize += new System.EventHandler(this.pnlMapContainer_Resize);
            // 
            // picMap
            // 
            this.picMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.picMap.Location = new System.Drawing.Point(0, 0);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(107, 62);
            this.picMap.TabIndex = 2;
            this.picMap.TabStop = false;
            this.picMap.Visible = false;
            this.picMap.DoubleClick += new System.EventHandler(this.picMap_DoubleClick);
            this.picMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseDown);
            this.picMap.MouseEnter += new System.EventHandler(this.picMap_MouseEnter);
            this.picMap.MouseLeave += new System.EventHandler(this.picMap_MouseLeave);
            this.picMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseMove);
            this.picMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseUp);
            //
            // tooltipMapAttribute
            //
            this.tooltipMapAttribute.Name = "tooltipMapAttribute";
            this.tooltipMapAttribute.Visible = false;
            // 
            // FrmMapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 101);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.pnlMapContainer);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FrmMapEditor";
            this.Text = "Map Editor";
            this.DockStateChanged += new System.EventHandler(this.frmMapEditor_DockStateChanged);
            this.Load += new System.EventHandler(this.frmMapEditor_Load);
            this.pnlFloorControls.ResumeLayout(false);
            this.pnlFloorControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloorLevel)).EndInit();
            this.pnlMapContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.picMap.Controls.Add(this.tooltipMapAttribute);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picMap;
        public System.Windows.Forms.Panel pnlMapContainer;
        public MapAttributeTooltip tooltipMapAttribute;
        private System.Windows.Forms.Panel pnlFloorControls;
        private DarkButton btnFloorDown;
        private DarkButton btnFloorUp;
        private DarkNumericUpDown nudFloorLevel;
        private System.Windows.Forms.Label lblFloorHeader;
        private System.Windows.Forms.Label lblMultiFloorHint;
    }
}
