﻿using Microsoft.AspNetCore.Mvc;

namespace PeerLandingFE.DTO.Req
{
    public class ReqAddUserDto : Controller
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role {  get; set; }

        public decimal Balance { get; set; }

    }
}
