using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using A8UI.Data.Domain;
using A8UI.Data.IRepository;
using A8UI.Data.IServices;


namespace A8UI.Data.Services
{
    public class PacienteService : IPacienteService
    {
        private IPacienteRepository pacienteRepository;
        public PacienteService(IPacienteRepository pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
        }

        public async Task<Paciente> Add(Paciente obj, CancellationToken ct = default)
        {
            var retvalue = await this.pacienteRepository.Add(obj, ct);
            return retvalue;
        }

        public Task<Paciente> Delete(Paciente obj, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Paciente>> GetAll(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Paciente> GetById(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Paciente> Update(Paciente obj, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
