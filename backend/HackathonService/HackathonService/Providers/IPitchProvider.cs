﻿using HackathonService.Dtos;

namespace HackathonService.Providers
{
    public interface IPitchProvider
    {
        Task<Pitch> SignUp(Guid id, User user);
        Task<Pitch> GetById(Guid id);
    }
}
