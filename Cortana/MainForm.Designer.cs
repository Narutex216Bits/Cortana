namespace Cortana
{
    partial class MainForm
    {
        /// <summary>
        /// Variável necessária ao designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cortanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirCalendárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invisívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocupadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDeNotificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirNotificaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOAssistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cortanaToolStripMenuItem
            // 
            this.cortanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.cortanaToolStripMenuItem.Name = "cortanaToolStripMenuItem";
            this.cortanaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.cortanaToolStripMenuItem.Text = "Assistente";
            // 
            // configuraçõesToolStripMenuItem1
            // 
            this.configuraçõesToolStripMenuItem1.Name = "configuraçõesToolStripMenuItem1";
            this.configuraçõesToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem1.Text = "Configurações";
            this.configuraçõesToolStripMenuItem1.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // calendárioToolStripMenuItem
            // 
            this.calendárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarDiaToolStripMenuItem,
            this.exibirCalendárioToolStripMenuItem});
            this.calendárioToolStripMenuItem.Name = "calendárioToolStripMenuItem";
            this.calendárioToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.calendárioToolStripMenuItem.Text = "Calendário";
            // 
            // agendarDiaToolStripMenuItem
            // 
            this.agendarDiaToolStripMenuItem.Name = "agendarDiaToolStripMenuItem";
            this.agendarDiaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.agendarDiaToolStripMenuItem.Text = "Agendar Dia";
            // 
            // exibirCalendárioToolStripMenuItem
            // 
            this.exibirCalendárioToolStripMenuItem.Name = "exibirCalendárioToolStripMenuItem";
            this.exibirCalendárioToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exibirCalendárioToolStripMenuItem.Text = "Exibir Calendário";
            // 
            // messengerToolStripMenuItem
            // 
            this.messengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.onlineToolStripMenuItem,
            this.offlineToolStripMenuItem,
            this.invisívelToolStripMenuItem,
            this.ausenteToolStripMenuItem,
            this.ocupadoToolStripMenuItem});
            this.messengerToolStripMenuItem.Name = "messengerToolStripMenuItem";
            this.messengerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.messengerToolStripMenuItem.Text = "Messenger";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.Checked = true;
            this.onlineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // offlineToolStripMenuItem
            // 
            this.offlineToolStripMenuItem.Name = "offlineToolStripMenuItem";
            this.offlineToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.offlineToolStripMenuItem.Text = "Offline";
            // 
            // invisívelToolStripMenuItem
            // 
            this.invisívelToolStripMenuItem.Name = "invisívelToolStripMenuItem";
            this.invisívelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.invisívelToolStripMenuItem.Text = "Invisível";
            // 
            // ausenteToolStripMenuItem
            // 
            this.ausenteToolStripMenuItem.Name = "ausenteToolStripMenuItem";
            this.ausenteToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ausenteToolStripMenuItem.Text = "Ausente";
            // 
            // ocupadoToolStripMenuItem
            // 
            this.ocupadoToolStripMenuItem.Name = "ocupadoToolStripMenuItem";
            this.ocupadoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ocupadoToolStripMenuItem.Text = "Ocupado";
            // 
            // notificaçõesToolStripMenuItem
            // 
            this.notificaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesDeNotificaçãoToolStripMenuItem,
            this.exibirNotificaçõesToolStripMenuItem});
            this.notificaçõesToolStripMenuItem.Name = "notificaçõesToolStripMenuItem";
            this.notificaçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.notificaçõesToolStripMenuItem.Text = "Notificações";
            // 
            // configuraçõesDeNotificaçãoToolStripMenuItem
            // 
            this.configuraçõesDeNotificaçãoToolStripMenuItem.Name = "configuraçõesDeNotificaçãoToolStripMenuItem";
            this.configuraçõesDeNotificaçãoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.configuraçõesDeNotificaçãoToolStripMenuItem.Text = "Configurações";
            // 
            // exibirNotificaçõesToolStripMenuItem
            // 
            this.exibirNotificaçõesToolStripMenuItem.Name = "exibirNotificaçõesToolStripMenuItem";
            this.exibirNotificaçõesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exibirNotificaçõesToolStripMenuItem.Text = "Exibir Notificações";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.sobreOAssistenteToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // sobreOAssistenteToolStripMenuItem
            // 
            this.sobreOAssistenteToolStripMenuItem.Name = "sobreOAssistenteToolStripMenuItem";
            this.sobreOAssistenteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sobreOAssistenteToolStripMenuItem.Text = "Sobre o Assistente";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cortana";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calendárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirCalendárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invisívelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocupadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDeNotificaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirNotificaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOAssistenteToolStripMenuItem;
    }
}
