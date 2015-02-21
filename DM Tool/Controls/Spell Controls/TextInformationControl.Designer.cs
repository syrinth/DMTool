namespace DM_Tool.Controls.Spell_Controls
{
    partial class TextInformationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSorcererSpells = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSorcererSpells
            // 
            this.txtSorcererSpells.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorcererSpells.Location = new System.Drawing.Point(0, 3);
            this.txtSorcererSpells.Multiline = true;
            this.txtSorcererSpells.Name = "txtSorcererSpells";
            this.txtSorcererSpells.Size = new System.Drawing.Size(583, 433);
            this.txtSorcererSpells.TabIndex = 0;
            // 
            // SpontaneousSpellsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSorcererSpells);
            this.Name = "SpontaneousSpellsControl";
            this.Size = new System.Drawing.Size(586, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSorcererSpells;
    }
}
