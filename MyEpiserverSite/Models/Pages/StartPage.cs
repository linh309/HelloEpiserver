using EPiServer.Core;
using EPiServer.DataAnnotations;
using System;

namespace MyEpiserverSite.Models.Pages
{
    [ContentType(Description = "My first start page", DisplayName = "EpiStartPage")]
    public class StartPage : PageData
    {

    }
}