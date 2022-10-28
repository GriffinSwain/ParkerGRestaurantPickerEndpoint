//Griffin Parker
//October 26, 2022
//Restaurant Picker - Endpoint
//This program gives the user instructions on how to run the program, takes what quality of restaurant they want, and then outputs what restaurant they should go to
//Peer Reviewed by andrea burr; i like how detailed it is it runs clean 10 out of 10

//  https://localhost:xxxx/RestaurantPicker     <= How to access instructions
//  https://localhost:xxxx/RestaurantPicker/RestaurantPicker/{quality}     <= How to access the main program. quality must be 'good, 'bad' or 'decent'

using Microsoft.AspNetCore.Mvc;

namespace ParkerGRestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    public string Instructions()
    {
        return "To run this program, type \n\n https://localhost:xxxx/RestaurantPicker/RestaurantPicker/{quality} \n\n Be sure to change the 'xxxx' to where your system is hosting it locally, and change {quality} to be either \"good\", \"bad\", or \"decent\"";
    }

    [HttpGet]
    [Route("RestaurantPicker/{quality}")]

    public string RestaurantPicker(string quality)
    {
        string picked = "";
        quality = quality.ToLower();
    string [] badRestaurants = {"Applebees", "Olive Garden", "McDonalds", "Burger King", "Del Taco", "Domino's", "Subway", "Your Nearest Greasy Chinese Restaurant", "Denny's", "Mimi's Cafe"};
    string [] decentRestaurants = {"In-n-Out", "Wendy's", "Five Guys", "Rubio's", "Your Local Taco Truck", "Taco Bell", "Old Spaghetti Factory", "PizzaHut", "Togo's", "Papa John's"};
    string [] goodRestaurants = {"Shadowbrook", "Smack Pie", "Market Tavern", "Papapavlo's", "The Creamery", "Fenton's", "The Dancing Fox", "Michael David Winery", "Prime Table Steakhouse", "Misaki Sushi"};
        Random rndNum = new Random();
        int num = rndNum.Next(0, 9);
        if (quality == "good") picked = goodRestaurants[num];
        if (quality == "decent") picked = decentRestaurants[num];
        if (quality == "bad") picked = badRestaurants[num];
        return $"You should eat at {picked}";
    }
}
