using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nuke_Safe_Login.Application.Core.AccessControl.Command.Login
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, LoginUserResponse>
    {
        public Task<LoginUserResponse> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
