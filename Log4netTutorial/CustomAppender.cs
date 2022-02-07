using log4net.Appender;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Log4netTutorial
{
    public class CustomAppender : AppenderSkeleton
    {
        protected override void Append(LoggingEvent loggingEvent)
        {
            Console.WriteLine($"{loggingEvent.Level.Name}: {RenderLoggingEvent(loggingEvent)}");
        }
    }
}
