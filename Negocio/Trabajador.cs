﻿using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Linq.Expressions;
using System.Text;

namespace SistemaPsicoaprende.Negocio
{
    public class Trabajador
    {
        private Trabajadores tra;//definir una instancia de la capa de datos Alumnos
        private string GenerarCodigoTrabajador()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                var ultimoTrabajador = ctx.Trabajadores.OrderByDescending(e => e.Id).FirstOrDefault();
                if (ultimoTrabajador != null)
                {
                    // Extraer el número del último código de trabajador
                    string ultimoCodigo = ultimoTrabajador.cod_Trabajador;
                    int ultimoNumero = int.Parse(ultimoCodigo.Substring(1));

                    // Incrementar el número del código y generar el nuevo código
                    int nuevoNumero = ultimoNumero + 1;
                    string nuevoCodigo = "T" + nuevoNumero.ToString("D3");
                    return nuevoCodigo.ToUpper();
                }
                else
                {
                    return "T001";
                }
            }
        }
        public Trabajador()
        {

        }
        public Trabajador(string codigo, string nombre, string apellido, string domicilio, string telefono, int profesionId, int departamentoId, int municipioId)
        {
            tra = new Trabajadores();

            if (string.IsNullOrEmpty(codigo))
            {
                // Generar un nuevo código de trabajador automáticamente
                tra.cod_Trabajador = GenerarCodigoTrabajador().ToUpper();
            }
            else
            {
                // Utilizar el código existente para una actualización
                tra.cod_Trabajador = codigo.ToUpper();
            }
            tra.nom_Trabajador = RemoveAccentsAndSpecialCharacters(nombre.ToUpper());
            tra.ape_Trabajador = RemoveAccentsAndSpecialCharacters(apellido.ToUpper());
            tra.domicilio_Trabajador = RemoveAccentsAndSpecialCharacters(domicilio.ToUpper());
            tra.telefono_Trabajador = RemoveAccentsAndSpecialCharacters(telefono.ToUpper());
            tra.ProfesionId = profesionId;
            tra.DepartamentoId = departamentoId;
            tra.MunicipioId = municipioId;
            tra.EstadoTrabajadorId = 2;
        }
        private string RemoveAccentsAndSpecialCharacters(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            Regex regex = new Regex("[^a-zA-Z0-9 ]");
            string result = regex.Replace(normalizedString, "");
            return result;
        }
        public int guardar()
        {
            int val = 0;

            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                if (string.IsNullOrEmpty(tra.cod_Trabajador))
                {
                    // Generar un nuevo código de trabajador automáticamente
                    tra.cod_Trabajador = GenerarCodigoTrabajador();
                }
                else
                {
                    // Buscar el trabajador existente por su código de trabajador
                    Trabajadores trabajadorExistente = ctx.Trabajadores.FirstOrDefault(e => e.cod_Trabajador == tra.cod_Trabajador);

                    if (trabajadorExistente != null)
                    {
                        // Actualizar los valores del trabajador existente con los valores de la instancia "tra"
                        trabajadorExistente.nom_Trabajador = RemoveAccentsAndSpecialCharacters(tra.nom_Trabajador.ToUpper());
                        trabajadorExistente.ape_Trabajador = RemoveAccentsAndSpecialCharacters(tra.ape_Trabajador.ToUpper());
                        trabajadorExistente.domicilio_Trabajador = RemoveAccentsAndSpecialCharacters(tra.domicilio_Trabajador.ToUpper());
                        trabajadorExistente.telefono_Trabajador = RemoveAccentsAndSpecialCharacters(tra.telefono_Trabajador.ToUpper());
                        trabajadorExistente.ProfesionId = tra.ProfesionId;
                        trabajadorExistente.DepartamentoId = tra.DepartamentoId;
                        trabajadorExistente.MunicipioId = tra.MunicipioId;
                        trabajadorExistente.EstadoTrabajadorId = tra.EstadoTrabajadorId;

                    }
                    else
                    {
                        // El trabajador no existe en la base de datos, es un nuevo registro
                        ctx.Trabajadores.Add(tra);
                    }
                }

                try
                {
                    val = ctx.SaveChanges();
                }
                catch
                {
                    throw new ArgumentNullException();
                    throw new InvalidCastException();
                    throw new System.Data.Entity.Infrastructure.DbUpdateException();
                }
            }

            return val;
        }
        public List<Departamentos> ObtenerDepartamentos()
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // retornamos la lista con los departamentos
                return ctx.Departamentos.ToList<Departamentos>();
            }
        }
        public List<Profesiones> Obtenerprofesiones()
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // retornamos la lista con los departamentos
                return ctx.Profesiones.ToList<Profesiones>();
            }
        }
        public List<Municipios> ObtenerMunicipiosPorDepartamento(int departamentoId)
        {

            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {

                // hacemos la consulta para seleccionarlos con inner join porque departamentos es fk en municipios
                var query = from m in ctx.Municipios
                            join d in ctx.Departamentos on m.DepartamentoId equals d.Id
                            where d.Id == departamentoId
                            select m;

                return query.ToList(); // retorna la lista con los municipios
            }
        }
        public Trabajadores ObtenerTrabajador(string codigo)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos el trabajador si existe , si existe pues retornaremos el objeto con sus atributos
            Trabajadores trabajador = ctx.Trabajadores.FirstOrDefault(e => e.cod_Trabajador == codigo);

            return trabajador; // retornando el objeto
        }
        public Trabajadores ObtenerTrabajadorId(int id)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos el trabajador si existe , si existe pues retornaremos el objeto con sus atributos
            Trabajadores trabajador = ctx.Trabajadores.FirstOrDefault(e => e.Id == id);

            return trabajador; // retornando el objeto
        }
        public List<Trabajadores> Leer()
        {
            //Establecer el contexto de la conexion 
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            //Hacer la consulta del estudiante a filtrar
            var Listtrabajadores = ctx.Trabajadores.Select(e => new
            {
                id = e.Id,
                Codigo = e.cod_Trabajador,
                Nombres = e.nom_Trabajador,
                Apellido = e.ape_Trabajador,
                Telefono = e.telefono_Trabajador
            }).ToList().Select(e => new Trabajadores()
            {
                Id = e.id,
                cod_Trabajador = e.Codigo,
                nom_Trabajador = e.Nombres,
                ape_Trabajador = e.Apellido,
                telefono_Trabajador = e.Telefono

            });
            return Listtrabajadores.ToList(); //retornar la lista trabajadores
        }

    }
}
