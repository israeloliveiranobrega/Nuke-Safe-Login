using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nuke_Safe_Login.Application.Core.AccessControl.Command.EmailVerifications
{
    public class EmailTokenVerificationResponse(string Token);
}
