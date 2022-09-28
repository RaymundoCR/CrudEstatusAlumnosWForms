using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudEstatusAlumnos.ADO;
using CrudEstatusAlumnos.Entidades;

namespace CrudEstatusAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<EstatusAlumno> _listaEstatus = new List<EstatusAlumno>();
        ADOEstatusAlumno _objAdo = new ADOEstatusAlumno();
        EstatusAlumno _estatusAlumno = new EstatusAlumno();

        public void recargarCbxGgv()
        {
            cbxClave.DataSource = _listaEstatus;
            cbxClave.DisplayMember = "Nombre";
            cbxClave.ValueMember = "id";
            dgvEstatus.DataSource = _listaEstatus;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _listaEstatus = _objAdo.Consultar();
            lbNombre.Visible=false;
            lbClave.Visible=false;
            txtNombre.Visible=false;
            txtClave.Visible=false;
            btnCancelar.Visible=false;
            btnGuardarAgregar.Visible=false;
            btnGuardarActualizar.Visible=false;
            btnSaveEliminar.Visible=false;

            recargarCbxGgv();
            //foreach (EstatusAlumno obj in _listaEstatus)
            //{
            //    _objAdo = new ADOEstatusAlumno();
            //    cbxClave.Items.Add(obj.clave);
            //}



            //foreach (EstatusAlumno obj in _listaEstatus)
            //{
            //    int i = dgvEstatus.Rows.Add();
            //    _objAdo = new ADOEstatusAlumno();
            //    dgvEstatus.Rows[i].Cells[0].Value = obj.id;
            //    dgvEstatus.Rows[i].Cells[1].Value = obj.nombre;
            //    dgvEstatus.Rows[i].Cells[2].Value = obj.clave;
            //    i++;
            //}
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            lbNombre.Visible = true;
            lbClave.Visible = true;
            txtNombre.Visible = true;
            txtClave.Visible = true;
            btnCancelar.Visible = true;
            btnGuardarAgregar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            lbNombre.Visible = false;
            lbClave.Visible = false;
            txtNombre.Visible = false;
            txtClave.Visible = false;
            btnCancelar.Visible = false;
            btnGuardarAgregar.Visible = false;

            _estatusAlumno = new EstatusAlumno();
            _estatusAlumno.nombre = txtNombre.Text;
            _estatusAlumno.clave = txtClave.Text;

            _objAdo.Agregar(_estatusAlumno);


            //foreach (EstatusAlumno obj in _listaEstatus)
            //{
            //    int i = dgvEstatus.Rows.Add();
            //    _objAdo = new ADOEstatusAlumno();
            //    dgvEstatus.Rows[i].Cells[0].Value = obj.id;
            //    dgvEstatus.Rows[i].Cells[1].Value = obj.nombre;
            //    dgvEstatus.Rows[i].Cells[2].Value = obj.clave;
            //    i++;
            //}
            _listaEstatus = _objAdo.Consultar();
            recargarCbxGgv();
            txtClave.Text = "";
            txtNombre.Text = "";

            //cbxClave.Items.Clear();
            //foreach (EstatusAlumno obj in _listaEstatus)
            //{
            //    _objAdo = new ADOEstatusAlumno();
            //    cbxClave.Items.Add(obj.clave);
            //}
        }
        

        EstatusAlumno _itemBuscado = new EstatusAlumno();
        public string _claveActualizar;
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            lbNombre.Visible = true;
            lbClave.Visible = true;
            txtNombre.Visible = true;
            txtClave.Visible = true;
            btnCancelar.Visible = true;
            btnGuardarAgregar.Visible = false;
            btnGuardarActualizar.Visible = true;

            _itemBuscado = (EstatusAlumno)cbxClave.SelectedItem;

            txtNombre.Text = _itemBuscado.nombre;
            txtClave.Text = _itemBuscado.clave;

            //_itemBuscado = _listaEstatus.First(x => x.clave == _claveActualizar);

            //_itemBuscado =
            //    (from status in _listaEstatus
            //    where status.clave == _claveActualizar
            //    select status).ToList();

            //_listaBuscado = itemBuscado.ToList();


            //_itemBuscado =
            //    from estatus in _listaEstatus
            //    where estatus.clave == _claveActualizar
            //    select estatus;

        }

        private void btnGuardarActualizar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            lbNombre.Visible = false;
            lbClave.Visible = false;
            txtNombre.Visible = false;
            txtClave.Visible = false;
            btnCancelar.Visible = false;
            btnGuardarAgregar.Visible = false;
            btnGuardarActualizar.Visible = false;

            _estatusAlumno = new EstatusAlumno();
            _estatusAlumno.id = _itemBuscado.id;
            _estatusAlumno.nombre = txtNombre.Text;
            _estatusAlumno.clave = txtClave.Text;

            //dgvEstatus.Rows.Clear();

            //_listaEstatus = _objAdo.Consultar();
            //foreach (EstatusAlumno obj in _listaEstatus)
            //{
            //    int i = dgvEstatus.Rows.Add();
            //    _objAdo = new ADOEstatusAlumno();
            //    dgvEstatus.Rows[i].Cells[0].Value = obj.id;
            //    dgvEstatus.Rows[i].Cells[1].Value = obj.nombre;
            //    dgvEstatus.Rows[i].Cells[2].Value = obj.clave;
            //    i++;
            //}
            _objAdo.Actualizar(_estatusAlumno);
            _listaEstatus = _objAdo.Consultar();
            recargarCbxGgv();
            txtClave.Text = "";
            txtNombre.Text = "";
            //cbxClave.Items.Clear();
            //foreach (EstatusAlumno obj in _listaEstatus)
            //{
            //    _objAdo = new ADOEstatusAlumno();
            //    cbxClave.Items.Add(obj.clave);
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            lbNombre.Visible = true;
            lbClave.Visible = true;
            txtNombre.Visible = true;
            txtClave.Visible = true;
            btnCancelar.Visible = true;
            btnGuardarAgregar.Visible = false;
            btnGuardarActualizar.Visible =false;
            btnSaveEliminar.Visible = true;

            //int indice = cbxClave.SelectedIndex;
            //_claveActualizar = cbxClave.Items[indice].ToString();

            _itemBuscado = (EstatusAlumno)cbxClave.SelectedItem;
            txtNombre.Text = _itemBuscado.nombre;
            txtClave.Text = _itemBuscado.clave;

            //_itemBuscado = _listaEstatus.First(x => x.clave == _claveActualizar);
            txtClave.Enabled = false;
            txtNombre.Enabled = false;
        }

        private void btnSaveEliminar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            lbNombre.Visible = false;
            lbClave.Visible = false;
            txtNombre.Visible = false;
            txtClave.Visible = false;
            btnCancelar.Visible = false;
            btnGuardarAgregar.Visible = false;
            btnGuardarActualizar.Visible = false;
            btnSaveEliminar.Visible=false;

            _estatusAlumno = new EstatusAlumno();
            int indice = cbxClave.SelectedIndex;
            _estatusAlumno.id = _itemBuscado.id;
            _estatusAlumno.nombre = txtNombre.Text;
            _estatusAlumno.clave = txtClave.Text;

            _objAdo.Eliminar(_estatusAlumno);
            _listaEstatus = _objAdo.Consultar();

            //dgvEstatus.Rows.Clear();
            //dgvEstatus.ClearSelection();
            //_objAdo.Eliminar(_estatusAlumno);
            //_listaEstatus = _objAdo.Consultar();
            //foreach (EstatusAlumno obj in _listaEstatus)
            //{
            //    int i = dgvEstatus.Rows.Add();
            //    _objAdo = new ADOEstatusAlumno();
            //    dgvEstatus.Rows[i].Cells[0].Value = obj.id;
            //    dgvEstatus.Rows[i].Cells[1].Value = obj.nombre;
            //    dgvEstatus.Rows[i].Cells[2].Value = obj.clave;
            //    i++;
            //}

            //cbxClave.Items.Clear();
            //foreach (EstatusAlumno obj in _listaEstatus)
            //{
            //    _objAdo = new ADOEstatusAlumno();
            //    cbxClave.Items.Add(obj.clave);
            //}
            recargarCbxGgv();
            txtClave.Text = "";
            txtNombre.Text = "";
            txtClave.Enabled = true;
            txtNombre.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            lbNombre.Visible = false;
            lbClave.Visible = false;
            txtNombre.Visible = false;
            txtClave.Visible = false;
            btnCancelar.Visible = false;
            btnGuardarAgregar.Visible = false;
            btnGuardarActualizar.Visible = false;
            btnSaveEliminar.Visible = false;
            txtClave.Text = "";
            txtNombre.Text = "";
        }
    }
}
