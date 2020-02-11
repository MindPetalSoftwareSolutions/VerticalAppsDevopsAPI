using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VerticalAppsDevopsAPI.Domain.Services;

namespace VerticalAppsDevopsAPI.Services{
    public class AuthenticationService : IAuthenticationService{
        private readonly IAuthenticationService _authenticationService;
    }
}