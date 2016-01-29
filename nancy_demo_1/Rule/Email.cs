using Nancy;
using Nancy.Routing;
using Nancy.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nancy_demo.Rule
{
    public class Email : RouteSegmentConstraintBase<string>
    {
        public override string Name
        {
            get { return "email"; }
        }

        protected override bool TryMatch(string constraint, string segment, out string matchedValue)
        {
            if (segment.Contains("@"))
            {
                matchedValue = segment;
                return true;
            }

            matchedValue = null;
            return false;
        }
        public interface IRoutePatternMatcher
        {
            /// <summary>
            /// Attempts to match a requested path with a route pattern.
            /// </summary>
            /// <param name="requestedPath">The path that was requested.</param>
            /// <param name="routePath">The route pattern that the requested path should be attempted to be matched with.</param>
            /// <param name="segments"> </param>
            /// <param name="context">The <see cref="NancyContext"/> instance for the current request.</param>
            /// <returns>An <see cref="IRoutePatternMatchResult"/> instance, containing the outcome of the match.</returns>
            IRoutePatternMatchResult Match(string requestedPath, string routePath, IEnumerable<string> segments, NancyContext context);
        }

    }
}