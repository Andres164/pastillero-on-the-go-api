﻿using GoPillBox.Database;
using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;

namespace GoPillBox.Repositories
{
    public class MedicationInTreatmentRepository : IMedicationInTreatmentRepository
    {
        private readonly GoPillBoxDbContext _dbContext;

        public MedicationInTreatmentRepository(GoPillBoxDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public Task<MedicationInTreatment?> CreateAsync(MedicationInTreatmentRequest newMedicationInTreatment)
        {
            throw new NotImplementedException();
        }

        public Task<MedicationInTreatment?> DeleteAsync(int medicationInTreatmentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicationInTreatment>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MedicationInTreatment?> ReadAsync(int medicationInTreatmentId)
        {
            throw new NotImplementedException();
        }

        public Task<MedicationInTreatment?> UpdateAsync(int id, MedicationInTreatmentRequest modifiedMedicationInTreatment)
        {
            throw new NotImplementedException();
        }
    }
}
