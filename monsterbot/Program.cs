using monsterbot;
using Microsoft.Extensions.Hosting;
using NetCord;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;
using NetCord.Rest;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddDiscordGateway()
    .AddApplicationCommands();

var host = builder.Build();

host.AddSlashCommand("slevy","Monster slevy aktuálně", () => MessageBuilder.CreateSaleMessage());

await host.RunAsync();
