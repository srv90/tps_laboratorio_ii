using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormGimnasio
{
    public partial class FrmGym : Form
    {

        #region Atributos
        private Gimnasio gimnasio;
        private Gimnasio gimnasioFiltrado;
        private Serializacion<List<Socio>> serializador;
        private string rutaArchivo;
        #endregion

        #region Propiedades
        public int Capacidad { get; }

        #endregion

        #region Constructores
        public FrmGym()
        {
            InitializeComponent();
        }
        #endregion


        #region Metodos
        /// <summary>
        /// Carga el listado y actualiza el listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGym_Load(object sender, EventArgs e)
        {


            serializador = new Serializacion<List<Socio>>();
            rutaArchivo = Environment.CurrentDirectory + @"\Socios.xml";
            gimnasio = new Gimnasio(this.EstablecerCapacidad(Capacidad));

            try
            {

                if (File.Exists(rutaArchivo))
                {
                    serializador.Importar(rutaArchivo, out this.gimnasio.lista);
                    this.ActualizarListBox();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.ActualizarDatos();
            this.lblCapacidadSocios.Text += gimnasio.Capacidad.ToString();

        }

        /// <summary>
        /// Agrega un nuevo socio al listado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSocio_Click(object sender, EventArgs e)
        {

            FrmAltaSocio frmSocio = new FrmAltaSocio();
            Socio socio;

            frmSocio.StartPosition = FormStartPosition.CenterScreen;

            DialogResult rta = frmSocio.ShowDialog();

            if (rta == DialogResult.OK)
            {
                socio = frmSocio.AgregarSocio();
                try
                {
                    if (gimnasio.Agregar(socio))
                    {

                        this.ActualizarListBox();
                        this.ActualizarDatos();

                    }
                    else
                    {
                        MessageBox.Show("El socio ya se encuentra ingresado", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (CapacidadMaximaException ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        /// <summary>
        /// Establece la capacidad del gimnasio
        /// </summary>
        /// <param name="capacidad"></param>
        /// <returns></returns>
        private int EstablecerCapacidad(int capacidad)
        {

            FrmCapacidad frmCapacidad = new FrmCapacidad();
            frmCapacidad.StartPosition = FormStartPosition.CenterScreen;

            DialogResult rta = frmCapacidad.ShowDialog();

            if (rta == DialogResult.OK)
            {
                capacidad = frmCapacidad.CapacidadGimnasio;

            }

            return capacidad;

        }

        /// <summary>
        /// Guarda el listado en formato .txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarListadoTxt_Click_1(object sender, EventArgs e)
        {
            if (this.lstSocios.Items.Count != this.gimnasio.lista.Count)
            {
                if (MessageBox.Show("El listado se guardara tal como figura en pantalla!",
                   "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    this.ExportTxt();
                }

            }
            else
            {
                this.ExportTxt();
            }
        }

        private void ExportTxt()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "TXT files|*.txt",
                Title = "Guardar archivo",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                DefaultExt = "txt",
                CheckPathExists = true,
                CheckFileExists = false,
                FileName = "Listado socios"

            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    sw.WriteLine("Listado generado el:  " + this.lblFecha.Text + "\n\n");

                    foreach (var item in lstSocios.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("\n\nTotal facturado: " + this.lblTotalFacturado.Text);
                    sw.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Guarda el listado en formato .xml este filtrado o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarListadoXml_Click(object sender, EventArgs e)
        {

            if (this.lstSocios.Items.Count > 0)
            {
                if (this.lstSocios.Items.Count != this.gimnasio.lista.Count)
                {
                    if (MessageBox.Show("El listado se guardara tal como figura en pantalla!",
                        "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {

                        this.ExportXml();
                    }
                    
                }
                else
                {
                    this.ExportXml();
                }
            }
            else
            {
                MessageBox.Show("El listado esta vacio!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ExportXml()
        {
            serializador = new Serializacion<List<Socio>>();
            try
            {
                if (!string.IsNullOrEmpty(this.txtFiltro.Text))
                {

                    this.gimnasio.lista = new List<Socio>(this.gimnasioFiltrado.lista);

                }

                if (serializador.Exportar(this.gimnasio.lista))
                {
                    MessageBox.Show("El archivo ha sido generado con exito." +
                                  " El mismo se encuentra en el escritorio.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualiza el listbox
        /// </summary>
        private void ActualizarListBox()
        {
            this.lstSocios.DataSource = null;
            this.lstSocios.DataSource = this.gimnasio.lista;

        }

        /// <summary>
        /// Elimina un socio del listado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Socio socio = this.lstSocios.SelectedItem as Socio;
            if (socio is not null)
            {

                if (MessageBox.Show("Estas seguro que deseas eliminar al socio actual?!",
                     "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (this.gimnasio.Remover(socio))
                    {
                        this.ActualizarDatos();
                        this.ActualizarListBox();
                    }
                }
            }
        }

        /// <summary>
        /// Actualza los labels cada vez que se agrega o elimina un socio
        /// </summary>
        private void ActualizarDatos()
        {
            this.lblNumLibres.Text = gimnasio.LugaresLibres.ToString();
            this.lblTotalFacturado.Text = "$ " + this.gimnasio.TotalFacturado().ToString();

        }

        /// <summary>
        /// Filtra el listbox en base a la palabra que se le escriba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            int dni;
            gimnasioFiltrado = new Gimnasio();
            if (!string.IsNullOrEmpty(this.txtFiltro.Text))
            {

                this.lstSocios.DataSource = null;
                this.lstSocios.Items.Clear();
                int.TryParse(this.txtFiltro.Text, out dni);
                foreach (Socio socio in this.gimnasio.lista)
                {
                    if (socio.Apellido.StartsWith(this.txtFiltro.Text, StringComparison.InvariantCultureIgnoreCase) ||
                        socio.Nombre.StartsWith(this.txtFiltro.Text, StringComparison.InvariantCultureIgnoreCase) ||
                        socio.Status.ToString().StartsWith(this.txtFiltro.Text,StringComparison.InvariantCultureIgnoreCase)||
                        socio.Pase.ToString().StartsWith(this.txtFiltro.Text, StringComparison.InvariantCultureIgnoreCase))
                     {
                        this.lstSocios.Items.Add(socio);
                        this.gimnasioFiltrado.Agregar(socio);
                    }
                }
            }
            else
            {
                this.ActualizarListBox();
            }
        }

        /// <summary>
        /// Establece la hora y dia actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmHora_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            this.lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// Abre la ventana de informes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformes_Click(object sender, EventArgs e)
        {
            if (this.gimnasio.lista.Count > 0)
            {
                FrmInformes frmInformes = new FrmInformes(this.gimnasio);
                frmInformes.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay socios ingresados!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Edita un socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Socio socio = this.lstSocios.SelectedItem as Socio;

            FrmAltaSocio frmSocio = new FrmAltaSocio(socio);

            frmSocio.StartPosition = FormStartPosition.CenterScreen;

            DialogResult rta = frmSocio.ShowDialog();

            if (rta == DialogResult.OK)
            {
                socio = frmSocio.AgregarSocio();
                try
                {
                    if (gimnasio.Agregar(socio))
                    {

                        this.ActualizarListBox();
                        this.ActualizarDatos();

                    }
                    else
                    {
                        MessageBox.Show("El socio ya se encuentra ingresado", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (CapacidadMaximaException ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
    }


    #endregion


}


