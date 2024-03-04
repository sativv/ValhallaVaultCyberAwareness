﻿using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class SegmentRepo
    {
        private readonly ApplicationDbContext context;

        public SegmentRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<SegmentModel>> GetAllAsync()
        {
            return await context.Segments.ToListAsync();
        }

        public async Task<SegmentModel?> GetByIdAsync(int id)
        {
            return await context.Segments.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            SegmentModel modelToRemove = await context.Segments.FirstOrDefaultAsync(a => a.Id == id);
            if (modelToRemove != null)
            {
                context.Segments.Remove(modelToRemove);
                await SaveChangesAsync();
            }

        }

        public async Task<SegmentModel> AddAsync(SegmentModel segmentToAdd)
        {
            await context.Segments.AddAsync(segmentToAdd);
            await SaveChangesAsync();
            return segmentToAdd;
        }
        public async Task<List<SegmentModel>> GetSegmentsInCategoryAsync(int categoryId)
        {
            return await context.Segments.Where(s => s.CategoryId == categoryId).ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
