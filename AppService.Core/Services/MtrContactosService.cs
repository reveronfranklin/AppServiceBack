using AppService.Core.CustomEntities;
using AppService.Core.DTOs;
using AppService.Core.Entities;
using AppService.Core.EntitiesClientes;
using AppService.Core.EntitiesSap;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AppService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class MtrContactosService: IMtrContactosService
    {

        private readonly IUnitOfWork _unitOfWork;
        public MtrContactosService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<MtrContactos> GetAll()
        {

            var contactos = _unitOfWork.MtrContactosRepository.GetAll();


            return contactos;
        }

        public async Task<MtrContactos> GetById(long id)
        {
            return await _unitOfWork.MtrContactosRepository.GetById(id);
        }

        public async Task<MtrContactos> Insert(MtrContactos mtrContactos)
        {


            await _unitOfWork.MtrContactosRepository.Add(mtrContactos);
            await _unitOfWork.SaveChangesAsync();
            return mtrContactos;
        }




        public async Task<MtrContactos> Update(MtrContactos mtrContactos)
        {

            var contacto = await GetById(mtrContactos.IdContacto);
            if (contacto == null)
            {
                throw new Exception("Contacto No existe");
            }

            _unitOfWork.MtrContactosRepository.Update(contacto);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(contacto.IdContacto);

        }

        public async Task<bool> Delete(long id)
        {
            await _unitOfWork.MtrContactosRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<List<MtrContactos>> GetByIdCliente(MtrClienteQueryFilter filter)
        {
            return await _unitOfWork.MtrContactosRepository.GetByEmailContactosCliente(filter);
        }

        public async Task<List<SapTratamientoContacto>> GetAllSapTratamientoContacto()
        {

            var tratamiento = await  _unitOfWork.SapTratamientoContactoRepository.GetAll();


            return tratamiento;

        }

        public async Task<List<SapCargoContacto>> GetAllSapCargoContacto()
        {

            var cargoContacto = await _unitOfWork.SapCargoContactoRepository.GetAll();


            return cargoContacto;

        }

        public async Task<List<SapDepartamentoContacto>> GetAllSapDepartamentoContacto()
        {

            var departamentoContacto = await _unitOfWork.SapDepartamentoContactoRepository.GetAll();


            return departamentoContacto;

        }

        public async Task<List<SapPoderContacto>> GetAllSapPoderContacto()
        {

            var poderContacto = await _unitOfWork.SapPoderContactoRepository.GetAll();


            return poderContacto;

        }


        public async Task<ApiResponse<bool>> CreateContactoAlTables(ContactoCreateDto dto)
        {

            bool resultDto = new bool();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);


            try
            {
                


               
                SapTratamientoContacto sapTratamientoContacto = await _unitOfWork.SapTratamientoContactoRepository.GetById(dto.Tratamiento);
                if (sapTratamientoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Tratamiento no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                SapDepartamentoContacto sapDepartamentoContacto = await _unitOfWork.SapDepartamentoContactoRepository.GetById(dto.Departamento);
                if (sapDepartamentoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Departamento no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                SapCargoContacto sapCargoContacto = await _unitOfWork.SapCargoContactoRepository.GetById(dto.Cargo);
                if (sapCargoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Cargo no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                SapPoderContacto sapPoderContacto = await _unitOfWork.SapPoderContactoRepository.GetById(dto.Poder);
                if (sapPoderContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Poder no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Rif))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Rif Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Nombre))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Nombre Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Apellido))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Apellido Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Celular))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Celular Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Telefono))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Email))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                var newIdContacto = await _unitOfWork.SapContactoRepository.NextId();

                string FlagProcesado = "";

                if (dto.IdCliente == "0")
                {
                    FlagProcesado = "X";
                }

                SapContactos newSapContactos = new SapContactos();

                newSapContactos.IdContacto = newIdContacto;
                newSapContactos.Kunnr = dto.IdCliente;
                newSapContactos.Parnr = "";
                newSapContactos.TitleMedi = sapTratamientoContacto.NombreTratamiento;
                newSapContactos.Name1 = dto.Apellido;
                newSapContactos.Namev = dto.Nombre;
                newSapContactos.Pafkt = sapCargoContacto.Codigo;
                newSapContactos.Abtnr = sapDepartamentoContacto.Codigo;
                newSapContactos.Telf1 = dto.Telefono;
                newSapContactos.Telf2 = dto.Celular;
                newSapContactos.StmpAddr = dto.Email;
                newSapContactos.Fax = dto.Fax;
                newSapContactos.Pavip = "3";//Activo
                if (dto.FechaNacimiento != null)
                {
                    newSapContactos.Gbdat = dto.FechaNacimiento.Value.Year.ToString() + dto.FechaNacimiento.Value.Month.ToString() + dto.FechaNacimiento.Value.Day.ToString();
                }
                    
                newSapContactos.Parvo = sapPoderContacto.Codigo;
                newSapContactos.Nmail = "X";
                newSapContactos.Procesado = FlagProcesado;
                newSapContactos.FechaCreacion = DateTime.Now;
                newSapContactos.UsuarioCreacion = dto.UsuarioConectado;
                await _unitOfWork.SapContactoRepository.Add(newSapContactos);


                MtrContactos newMtrContactos = new MtrContactos();
                newMtrContactos.IdContacto = (long)newIdContacto;
                newMtrContactos.IdCliente = dto.IdCliente;
                newMtrContactos.Rif = dto.Rif;
                newMtrContactos.Nombre = dto.Nombre + " " + dto.Apellido;
                newMtrContactos.Cargo = sapCargoContacto.Descripcion;
                newMtrContactos.Area = sapDepartamentoContacto.Descripcion;
                newMtrContactos.Telefono1 = dto.Telefono;
                newMtrContactos.Celular = dto.Celular;
                newMtrContactos.Email = dto.Email;
                newMtrContactos.Fax = dto.Fax;
                newMtrContactos.Inactivo = false;
                newMtrContactos.FechaCreacion = DateTime.Now;
                newMtrContactos.Usuario = dto.UsuarioConectado;
                await _unitOfWork.MtrContactosRepository.Add(newMtrContactos);

                Wsmy265 newWsmy265 = new Wsmy265();

                decimal decimalVal = 0;
                decimalVal = System.Convert.ToDecimal(dto.IdCliente);
                var newCorrelativoContactoCliente = await _unitOfWork.Wsmy265Repository.NextCorrelativoContactoCliente(decimalVal, dto.Rif);
                newWsmy265.Id= (long)newIdContacto;
                newWsmy265.Cliente = decimalVal;
                newWsmy265.Rif = dto.Rif;
                newWsmy265.Nombre = dto.Nombre + " " + dto.Apellido;
                newWsmy265.Cargo = sapCargoContacto.Descripcion;
                newWsmy265.Area = sapDepartamentoContacto.Descripcion;
                newWsmy265.TelefonoOficina1 = dto.Telefono;
                newWsmy265.TelefonoCelular = dto.Celular;
                newWsmy265.Email = dto.Email;
                newWsmy265.Fax = dto.Fax;
                newWsmy265.IdContactos = newCorrelativoContactoCliente;
                newWsmy265.Inactivo = "";
                if (dto.FechaNacimiento != null)
                {
                    newWsmy265.FechaCumpleanos = dto.FechaNacimiento.Value.Year.ToString() + dto.FechaNacimiento.Value.Month.ToString() + dto.FechaNacimiento.Value.Day.ToString();

                }

                newWsmy265.TomaDecision = sapPoderContacto.Id;
                newWsmy265.AceptaEmail = "X";
                newWsmy265.FechaCreacion = DateTime.Now;
                newWsmy265.Usuario = dto.UsuarioConectado;

                await _unitOfWork.Wsmy265Repository.Add(newWsmy265);
                
                
                await _unitOfWork.SaveChangesAsync();


                response.Data = true;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = false;
                response.Meta = metadata;
                return response;
            }





        }

        public async Task<ApiResponse<bool>> UpdateContactoAllTables(ContactoUpdateDto dto)
        {

            bool resultDto = new bool();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<bool> response = new ApiResponse<bool>(resultDto);


            try
            {

               



                SapTratamientoContacto sapTratamientoContacto = await _unitOfWork.SapTratamientoContactoRepository.GetById(dto.Tratamiento);
                if (sapTratamientoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Tratamiento no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                SapDepartamentoContacto sapDepartamentoContacto = await _unitOfWork.SapDepartamentoContactoRepository.GetById(dto.Departamento);
                if (sapDepartamentoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Departamento no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                SapCargoContacto sapCargoContacto = await _unitOfWork.SapCargoContactoRepository.GetById(dto.Cargo);
                if (sapCargoContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Cargo no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                SapPoderContacto sapPoderContacto = await _unitOfWork.SapPoderContactoRepository.GetById(dto.Poder);
                if (sapPoderContacto == null)
                {

                    metadata.IsValid = false;
                    metadata.Message = "Poder no existe!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Rif))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Rif Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Nombre))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Nombre Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
              
                if (String.IsNullOrEmpty(dto.Celular))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Celular Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Telefono))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                if (String.IsNullOrEmpty(dto.Email))
                {

                    metadata.IsValid = false;
                    metadata.Message = "Telefono Invalido!!";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }

                var newIdContacto = await _unitOfWork.SapContactoRepository.NextId();

                string FlagProcesado = "";

                if (dto.IdCliente == "0")
                {
                    FlagProcesado = "X";
                }

                MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById((long)dto.IdContacto);
                if (mtrContactos == null)
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No existe";
                    response.Data = false;
                    response.Meta = metadata;
                    return response;
                }
                else
                {

                    mtrContactos.Rif = dto.Rif;
                    mtrContactos.Nombre = dto.Nombre;
                    mtrContactos.Cargo = sapCargoContacto.Descripcion;
                    mtrContactos.Area = sapDepartamentoContacto.Descripcion;
                    mtrContactos.Telefono1 = dto.Telefono;
                    mtrContactos.Celular = dto.Celular;
                    mtrContactos.Email = dto.Email;
                    mtrContactos.Fax = dto.Fax;
                    mtrContactos.Inactivo = false;
                    mtrContactos.FechaCreacion = DateTime.Now;
                    mtrContactos.Usuario = dto.UsuarioConectado;
                    _unitOfWork.MtrContactosRepository.Update(mtrContactos);
                    SapContactos sapContactos = await _unitOfWork.SapContactoRepository.GetById(mtrContactos.IdContacto);
                    if (sapContactos!=null)
                    {
                        sapContactos.Parnr = "";
                        sapContactos.TitleMedi = sapTratamientoContacto.NombreTratamiento;
                        sapContactos.Name1 = dto.Apellido;
                        sapContactos.Namev = dto.Nombre;
                        sapContactos.Pafkt = sapCargoContacto.Codigo;
                        sapContactos.Abtnr = sapDepartamentoContacto.Codigo;
                        sapContactos.Telf1 = dto.Telefono;
                        sapContactos.Telf2 = dto.Celular;
                        sapContactos.StmpAddr = dto.Email;
                        sapContactos.Fax = dto.Fax;
                        sapContactos.Pavip = "3";//Activo
                        if (dto.FechaNacimiento!=null)
                        {
                            sapContactos.Gbdat = dto.FechaNacimiento.Value.Year.ToString() + dto.FechaNacimiento.Value.Month.ToString() + dto.FechaNacimiento.Value.Day.ToString();
                        }
                        
                        sapContactos.Parvo = sapPoderContacto.Codigo;
                        sapContactos.Nmail = "X";
                        sapContactos.Procesado = FlagProcesado;
                        sapContactos.FechaCreacion = DateTime.Now;
                        sapContactos.UsuarioCreacion = dto.UsuarioConectado;
                        _unitOfWork.SapContactoRepository.Update(sapContactos);
                    }
                    Wsmy265 wsmy265 = await _unitOfWork.Wsmy265Repository.GetById(mtrContactos.IdContacto);
                    if (wsmy265!=null)
                    {
                        wsmy265.Rif = dto.Rif;
                        wsmy265.Nombre = dto.Nombre + " " + dto.Apellido;
                        wsmy265.Cargo = sapCargoContacto.Descripcion;
                        wsmy265.Area = sapDepartamentoContacto.Descripcion;
                        wsmy265.TelefonoOficina1 = dto.Telefono;
                        wsmy265.TelefonoCelular = dto.Celular;
                        wsmy265.Email = dto.Email;
                        wsmy265.Fax = dto.Fax;
                        wsmy265.Inactivo = "";
                        if (dto.FechaNacimiento!=null)
                        {
                            wsmy265.FechaCumpleanos = dto.FechaNacimiento.Value.Year.ToString() + dto.FechaNacimiento.Value.Month.ToString() + dto.FechaNacimiento.Value.Day.ToString();
                        }
                        
                        wsmy265.TomaDecision = sapPoderContacto.Id;
                        wsmy265.AceptaEmail = "X";
                        wsmy265.Usuario = dto.UsuarioConectado;

                        _unitOfWork.Wsmy265Repository.Update(wsmy265);
                    }

                    await _unitOfWork.SaveChangesAsync();
                }


                response.Data = true;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = false;
                response.Meta = metadata;
                return response;
            }





        }

        public async Task<ApiResponse<ContactoGetDto>> GetContactoById(ContactoQueryFilter filter)
        {

            ContactoGetDto resultDto = new ContactoGetDto();

            Metadata metadata = new Metadata
            {
                IsValid = true,
                Message = ""

            };

            ApiResponse<ContactoGetDto> response = new ApiResponse<ContactoGetDto>(resultDto);


            try
            {




                MtrContactos mtrContactos = await _unitOfWork.MtrContactosRepository.GetById((long)filter.IdContacto);
                if (mtrContactos != null)
                {

                    SapContactos sapContactos = await _unitOfWork.SapContactoRepository.GetById(mtrContactos.IdContacto);

                    ContactoGetDto contactoGetDto = new ContactoGetDto();
                    if (sapContactos.TitleMedi=="Señor")
                    {
                        contactoGetDto.Tratamiento = 1;
                    }
                    else
                    {
                        contactoGetDto.Tratamiento = 2;
                    }
                    
                    contactoGetDto.Poder = sapContactos.Parvo;
                    contactoGetDto.Nombre = mtrContactos.Nombre;
                    contactoGetDto.Departamento = sapContactos.Abtnr;
                    contactoGetDto.Telefono = mtrContactos.Telefono1;
                    contactoGetDto.Celular = mtrContactos.Celular;
                    contactoGetDto.Fax = mtrContactos.Fax;
                    contactoGetDto.Email = mtrContactos.Email;
                    contactoGetDto.IdContacto = mtrContactos.IdContacto;
                    contactoGetDto.IdCliente = mtrContactos.IdCliente;
                    contactoGetDto.Rif = mtrContactos.Rif;
                    contactoGetDto.Cargo = sapContactos.Pafkt;

                    metadata.IsValid = true;
                    metadata.Message = "";
                    response.Data = contactoGetDto;
                    response.Meta = metadata;
                    return response;
                }
                else
                {
                    metadata.IsValid = false;
                    metadata.Message = "Contacto No existe";
                    response.Data = null;
                    response.Meta = metadata;
                    return response;
                }
              

                response.Data = null;
                response.Meta = metadata;
                return response;

            }
            catch (Exception ex)
            {

                metadata.IsValid = false;
                metadata.Message = ex.InnerException.Message;
                response.Data = null;
                response.Meta = metadata;
                return response;
            }





        }






    }
}
