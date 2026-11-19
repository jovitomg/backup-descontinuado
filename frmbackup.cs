using System;
using System.ComponentModel;


namespace Backup {
    public partial class frmbackup : Erp.Classe.frmtela {
        
        System.ComponentModel.BackgroundWorker bgwexeutar;

        public frmbackup() {
            InitializeComponent();

            bgwexeutar = new System.ComponentModel.BackgroundWorker();
            bgwexeutar.WorkerReportsProgress = true;
            bgwexeutar.WorkerSupportsCancellation = true;
            bgwexeutar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwexeutar_DoWork);
            bgwexeutar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwexeutar_RunWorkerCompleted);
        }

        private void bgwexeutar_DoWork(object sender, DoWorkEventArgs e) {
            gerar_backup();
        }

        private void bgwexeutar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Cancelled) {

            } else if (e.Error != null) {

            } else {
                
            }
            Close();
        }

        public override void ajusta_size() {
            base.ajusta_size();
            MinimumSize = Size;
            MaximumSize = Size;
        }

        private void frmbackup_Load(object sender, EventArgs e) {
            if (BaseMt.Controle.Cadastro.validarConfiguracaoAmbiente()) {
                bgwexeutar.RunWorkerAsync();
            }            
        }        

        private void gerar_backup() {
            BaseMt.Controle.Cadastro.gerar_backup(Data.Controle.Usuario.confGeral.confBackup.nuvem);
        }

    }
}

