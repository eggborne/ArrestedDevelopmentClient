using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArrestedDevelopmentClient.Models
{
  public class Quote
  {
    public int QuoteId { get; set; }
    public string Text { get; set; }
    public string Speaker { get; set; }
    public int NumberOfWords { get; set; }

    public static List<Quote> GetQuotes()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Quote> quoteList = JsonConvert.DeserializeObject<List<Quote>>(jsonResponse.ToString());

      return quoteList;
    }
  }
}