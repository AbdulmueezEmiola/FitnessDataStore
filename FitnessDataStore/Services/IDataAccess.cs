using FitnessDataStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessDataStore.Services
{
    public interface IDataAccess
    {
        Task<bool> WriteRecord(FitnessRecord newRecord);
        Task<List<FitnessRecord>> GetAllRecords();
        Task<List<FitnessRecord>> GetRecordsByWorkoutType(string workoutType);
        Task<FitnessRecord> GetRecordByTitle(string title);
        Task<bool> UpdateRecord(string title, string newComment);
        Task<bool> DeleteRecord(String title);
    }
}
