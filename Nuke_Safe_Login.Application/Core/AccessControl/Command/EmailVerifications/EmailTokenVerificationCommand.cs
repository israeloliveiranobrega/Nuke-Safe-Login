using MediatR;
using Nuke_Safe_Login.Application.Core.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nuke_Safe_Login.Application.Core.AccessControl.Command.EmailVerifications
{
    public class EmailTokenVerificationCommand(string recipient, EmailPostDTO post) : IRequest<EmailTokenVerificationResponse>
    {
        public string Recipient { get; } = recipient;
        public EmailPostDTO Post { get; } = post;
    }
}
