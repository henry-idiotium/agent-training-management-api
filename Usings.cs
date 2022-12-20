global using AtmAPI.Commons.Controllers;
global using AtmAPI.Commons.Models.DTOs;
global using AtmAPI.Commons.Models.Entities;
global using AtmAPI.Constants;
global using AtmAPI.Data;
global using AtmAPI.Extensions;
global using AtmAPI.Extensions.Attributes;
global using AtmAPI.Helpers;
global using AtmAPI.Helpers.Authorization;
global using AtmAPI.Models.DTOs;
global using AtmAPI.Models.DTOs.Attendance;
global using AtmAPI.Models.DTOs.Category;
global using AtmAPI.Models.DTOs.Class;
global using AtmAPI.Models.DTOs.ClassLecturer;
global using AtmAPI.Models.DTOs.ExternalInstitution;
global using AtmAPI.Models.DTOs.Lecturer;
global using AtmAPI.Models.DTOs.Operator;
global using AtmAPI.Models.DTOs.Schedule;
global using AtmAPI.Models.DTOs.ServiceProviders;
global using AtmAPI.Models.DTOs.Skill;
global using AtmAPI.Models.DTOs.SkillReport;
global using AtmAPI.Models.DTOs.Slot;
global using AtmAPI.Models.DTOs.Student;
global using AtmAPI.Models.Entities;
global using AtmAPI.Repositories;
global using AtmAPI.Services;
global using AutoMapper;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Storage;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Options;
global using Newtonsoft.Json;
global using Sieve.Models;
global using Sieve.Services;
global using System;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Linq;
global using System.Linq.Expressions;
global using System.Net;
global using System.Net.Mime;
global using System.Threading.Tasks;
global using Throw;
global using static AtmAPI.Helpers.EnvVars;