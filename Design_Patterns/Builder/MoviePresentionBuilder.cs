using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder;

public class MoviePresentionBuilder : PresentionBuilder
{
    private Movie movie = new Movie();
    public void addSlide(Slide slide)
    {
        movie.addFrame(slide.getText(), 5);
    }

    public Movie get()
    {
        return movie;
    }
}
