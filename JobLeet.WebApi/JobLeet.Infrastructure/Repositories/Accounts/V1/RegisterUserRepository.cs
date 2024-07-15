﻿using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Utilities;
using JobLeet.WebApi.JobLeet.Validator.EntityValidator.V1;
using Microsoft.EntityFrameworkCore;


namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Accounts.V1
{
    public class RegisterUserRepository : IRegisterUserRepository
    {
        #region Initialization
        // <returns>The list of initializations</returns>
        private readonly BaseDBContext _dbContext;

        public RegisterUserRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        }
        #endregion
        public async Task<RegisterUserModel> AddAsync(RegisterUserModel entity)
        {
            try
            {
                #region ToJobLeetDB

                // ValidationUserAsync validates the PersonName, Password and EmailAddress
                await ValidateUserAsync(entity);

                // Generates the hashedpasscode and Salt string to ensure User's Password security.
                var (hashedPasscode, saltString) = GenerateUniqueHashedPassword(entity.Password);
                var newUser = new RegisterUser
                {
                    PersonName = new PersonName {
                        Id = entity.PersonName.Id,
                        FirstName = entity.PersonName.FirstName.Trim().ToLower(),
                        MiddleName = entity?.PersonName?.MiddleName?.Trim().ToLower(),
                        LastName = entity?.PersonName?.LastName?.Trim().ToLower(),
                    },
                   // UserName = entity.UserName.Trim().ToLower(),
                    UserEmail = new Email
                    {
                        Id = entity.UserEmail.Id,
                        EmailAddress = entity.UserEmail.EmailAddress,
                        EmailType = Core.Entities.Common.V1.EmailCategory.Personal
                    },
                    Password = hashedPasscode,
                    ConfirmPassword = hashedPasscode,
                    Salt = saltString
                };

                _dbContext.RegisterUsers.Add(newUser);
                await _dbContext.SaveChangesAsync();

                #endregion

                #region ToAPIResponse
                // Not exposing Salt for security concerns. 
                var responseEntity = new RegisterUserModel
                {
                    PersonName = new PersonNameModel{
                        Id = newUser.PersonName.Id,
                        FirstName = newUser.PersonName.FirstName,
                        MiddleName = newUser.PersonName.MiddleName,
                        LastName = newUser.PersonName.LastName,
                    },
                    UserEmail = new EmailModel
                    {
                        Id = newUser.UserEmail.Id,
                        EmailAddress = newUser.UserEmail.EmailAddress,
                        EmailType = Api.Models.Common.V1.EmailCategory.Personal
                    },
                    // Password = hashedPasscode,
                    // ConfirmPassword = hashedPasscode,
                    Id = newUser.Id
                };

                return responseEntity;
            }
            #endregion
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException($"Error occurred while Creating the user registration {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred: {ex.Message}", ex);
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RegisterUserModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RegisterUserModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(RegisterUserModel entity)
        {
            throw new NotImplementedException();
        }


        #region  Utility Methods

        private async Task ValidateUserAsync(RegisterUserModel entity)
        {
            bool emailExists = await _dbContext.RegisterUsers.AnyAsync(u => u.UserEmail.EmailAddress == entity.UserEmail.EmailAddress);
            bool emailValidator = EmailAddressValidator.IsValidEmail(entity.UserEmail.EmailAddress);
            bool passwordValidator = PasswordValidation.ValidatePassword(entity.Password);

            var checkFirstName = PersonNameValidator.IsValidUsername(entity.PersonName.FirstName);
            var checkMiddleName = PersonNameValidator.IsValidMiddleName(entity.PersonName.MiddleName);
            var checkLastName = PersonNameValidator.IsValidUsername(entity.PersonName.LastName);

            if(!checkFirstName || !checkLastName || !checkMiddleName){
                throw new Exception("Invalid syntax for FirstName, MiddleName or LastName");
            }
            if (emailExists)
            {
                throw new Exception("This email address is already registered.");
            }

            if (!emailValidator)
            {
                throw new Exception("Invalid Email Format");
            }

            if (!passwordValidator)
            {
                throw new ArgumentException("Password must be between 8 and 100 characters and should match the regular expression pattern");
            }
        }

        private (string hashedPassword, string salt) GenerateUniqueHashedPassword(string password)
        {
            byte[] salt = GenerateHashedPassword.GenerateSalt();
            string saltString = Convert.ToBase64String(salt);
            string hashedPassword = GenerateHashedPassword.HashedPassword(password, saltString);
            return (hashedPassword, saltString);
        }
        #endregion

    }
}
