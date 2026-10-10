using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder;

public class Presention
{
    private List<Slide> Slides = new List<Slide>();
    public void addSlide(Slide slide)
    {
        Slides.Add(slide);
    }

    public void export (PresentionBuilder builder)
    {
        builder.addSlide(new Slide("Copywrite"));
      foreach(var slide in Slides)
        {
            builder.addSlide(slide);
        }

        }
    }

