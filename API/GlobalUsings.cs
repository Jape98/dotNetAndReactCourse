global using API.Extensions;
global using API.Middleware;
global using API.SignalR;
global using MediatR;
global using Domain;
global using Persistence;
global using FluentValidation.AspNetCore;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Authorization;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.SignalR;
global using System.Security.Claims;
global using System.Text;
global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Cryptography;
global using API.Services;
global using Infrastructure.Security;
global using Microsoft.AspNetCore.Authentication.JwtBearer;