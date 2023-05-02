using System.Text.Json.Nodes;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.DAL;

public class MapApi
{
    private Tour tour;
    private string key = "gaOGsXknfsoJ4v5IdQTUwyrv8qtCqPIT";
    
    public MapApi(Tour tour)
    {
        this.tour = tour;
    }
    
    public async Task CreateMap()
    {
        string url = $"https://www.mapquestapi.com/directions/v2/route?key={key}&from={tour.From}&to={tour.To}&unit=k&traffic=false&routeType=bicycle";
        using var client = new HttpClient();
        var response = await client.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        var rootNode = JsonNode.Parse(content);

        var sessionId = rootNode["route"]["sessionId"].ToString();
        var boundingBox = rootNode["route"]["boundingBox"];
        var ul_lat = boundingBox["ul"]["lat"].ToString();
        var ul_lng = boundingBox["ul"]["lng"].ToString();
        var lr_lat = boundingBox["lr"]["lat"].ToString();
        var lr_lng = boundingBox["lr"]["lng"].ToString();

        url = $"https://www.mapquestapi.com/staticmap/v5/map?key={key}&boundingBox={ul_lat},{ul_lng},{lr_lat},{lr_lng}&size=600,600&session={sessionId}&type=dark";

        var stream = await client.GetStreamAsync(url);
        await using var fileStream = new FileStream($"{tour.Information}", FileMode.Create, FileAccess.Write);
        stream.CopyTo(fileStream);
    }
}