﻿using SchoolDB.Appcore.Interfaces;
using SchoolDB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDB.Presentation
{
    public partial class Form1 : Form
    {
        private IEstudianteService estudianteService;
        public Form1(IEstudianteService estudianteService)
        {
            this.estudianteService = estudianteService;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante()
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellido.Text,
                Carnet = txtCarnet.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text,
                Phone = txtTelefono.Text,
                Matematicas = (int)nudMatematicas.Value,
                Contabilidad = (int)nudContabilidad.Value,
                Estadistica = (int)nudEstadistica.Value,
                Programacion = (int)nudProgramacion.Value

            };

            estudianteService.Create(estudiante);

            dgvStudent.DataSource = estudianteService.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = estudianteService.GetAll();
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione un estudiante");
                return;
            }

            Estudiante estudent = new Estudiante()
            {
                Id = (int) dgvStudent.CurrentRow.Cells[0].Value, 
                Nombres = txtNombre.Text,
                Apellidos = txtApellido.Text,
                Carnet = txtCarnet.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text,
                Phone = txtTelefono.Text,
                Matematicas = (int)nudMatematicas.Value,
                Contabilidad = (int)nudContabilidad.Value,
                Estadistica = (int)nudEstadistica.Value,
                Programacion = (int)nudProgramacion.Value
            };

            estudianteService.Update(estudent);
            dgvStudent.DataSource = estudianteService.GetAll();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = (string)dgvStudent.CurrentRow.Cells[1].Value;
            txtApellido.Text = (string)dgvStudent.CurrentRow.Cells[2].Value;
            txtCarnet.Text = (string)dgvStudent.CurrentRow.Cells[3].Value;
            txtDireccion.Text = (string)dgvStudent.CurrentRow.Cells[5].Value;
            txtCorreo.Text = (string)dgvStudent.CurrentRow.Cells[6].Value;
            txtTelefono.Text = (string)dgvStudent.CurrentRow.Cells[4].Value;
            nudMatematicas.Value = (int)dgvStudent.CurrentRow.Cells[7].Value;
            nudContabilidad.Value = (int)dgvStudent.CurrentRow.Cells[8].Value;
            nudEstadistica.Value = (int)dgvStudent.CurrentRow.Cells[10].Value;
            nudProgramacion.Value = (int)dgvStudent.CurrentRow.Cells[9].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione un estudiante");
                return;
            }

            int id = (int)dgvStudent.CurrentRow.Cells[0].Value;

            Estudiante estudiante = estudianteService.FindById(id);
            estudianteService.Delete(estudiante);
            dgvStudent.DataSource = estudianteService.GetAll();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione un estudiante");
                return;
            }

            int id = (int)dgvStudent.CurrentRow.Cells[0].Value;

            Estudiante estudiante = estudianteService.FindById(id);
            decimal promedio = estudianteService.Promedio(estudiante);

            MessageBox.Show($"El promedio del estudiante: {estudiante.Nombres} es:  {promedio}");
        }
    }
}