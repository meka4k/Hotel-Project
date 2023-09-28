﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JwtProject.Models
{
    public class CreateToken
    {
        public string CreateJwtToken()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddSeconds(20), signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);
        }

        public string CreateJwtAdminToken()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Role, "Admin"),
            new Claim(ClaimTypes.Role, "Visitor"),

            };
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddSeconds(20), signingCredentials: credentials, claims: claims);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);
        }
    }
}
