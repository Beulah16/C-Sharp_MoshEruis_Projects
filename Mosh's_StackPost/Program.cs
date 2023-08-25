using System;
namespace Intermediate
{
    class UsingPost
    {
        /*Design a class called Post which models a StackOverflow post. 
         It should have properties for title, description and the date/time it was created. 
         We should be able to up-vote or down-vote a post. We should also be able to see the current vote value. 
         In the main method, create a post,up-vote and down-vote it a few times and then display the the current vote value.*/
         static void Main(string[]args)
         {
            var post = new Post();
            post.RequestTitle();
            post.RequestDescription();

         }
    }
}