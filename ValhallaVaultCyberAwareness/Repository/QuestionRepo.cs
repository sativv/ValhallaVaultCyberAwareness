﻿using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class QuestionRepo
    {
        private readonly ApplicationDbContext context;

        public QuestionRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<QuestionModel>> GetAllAsync()
        {
            return await context.Questions.ToListAsync();
        }

        public async Task<QuestionModel?> GetByIdAsync(int id)
        {
            return await context.Questions.Include(q => q.SubCategory).FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            QuestionModel modelToRemove = await context.Questions.FirstOrDefaultAsync(q => q.Id == id);
            if (modelToRemove != null)
            {
                context.Questions.Remove(modelToRemove);
                await SaveChangesAsync();
            }

        }
        public async Task<List<QuestionModel>> GetQuestionsInSubCategoryAsnyc(int subCategoryId)
        {
            return await context.Questions.Where(q => q.SubCategoryId == subCategoryId).ToListAsync();
        }

        public async Task<List<QuestionModel>> GetQuestionsInSegmentAsnyc(int segmentId)
        {
            return await context.Questions.Include(q => q.SubCategory).Where(q => q.SubCategory.SegmentId == segmentId).ToListAsync();
        }

        public async Task<List<QuestionModel>> GetQuestionsInCategoryAsync(int categoryId)
        {
            return await context.Questions.Include(q => q.SubCategory).ThenInclude(q => q.Segment).Where(q => q.SubCategory.Segment.CategoryId == categoryId).ToListAsync();
        }

        public async Task<QuestionModel> AddAsync(QuestionModel questionToAdd)
        {
            await context.Questions.AddAsync(questionToAdd);
            await SaveChangesAsync();
            return questionToAdd;
        }

        public async Task UpdateAsync(int id, QuestionModel newQuestion)
        {
            QuestionModel questionToUpdate = await context.Questions.FirstOrDefaultAsync(c => c.Id == id);
            if (questionToUpdate != null)
            {
                if (newQuestion.Text != null)
                {

                    questionToUpdate.Text = newQuestion.Text;
                }
                if (newQuestion.ExplanationText != null)
                {
                    questionToUpdate.ExplanationText = newQuestion.ExplanationText;
                }
                if (newQuestion.Title != null)
                {

                    questionToUpdate.Title = newQuestion.Title;
                }
                if (newQuestion.SubCategoryId != null && newQuestion.SubCategoryId != 0)
                {
                    questionToUpdate.SubCategoryId = newQuestion.SubCategoryId;
                }


            }
            await SaveChangesAsync();

        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }



    }
}
