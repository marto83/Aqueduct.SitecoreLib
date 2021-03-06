﻿using Aqueduct.SitecoreLib.DataAccess;
using Aqueduct.SitecoreLib.Examples.SampleApplication.Business.Domain;
using Aqueduct.SitecoreLib.Examples.SampleApplication.Business.Domain.Widgets;
using Aqueduct.SitecoreLib.Examples.SampleApplication.DataAccess.Resolvers;

namespace Aqueduct.SitecoreLib.Examples.SampleApplication.DataAccess.Maps
{
    public class ContentPageMap : Map<ContentPage>
    {
        public ContentPageMap()
        {
            MapProperty(x => x.Widgets).SetResolver(new InferredMultiListValueResolver<IWidget>("Widgets"));
            MapProperty(x => x.Headline);
            MapProperty(x => x.Summary);
            MapProperty(x => x.Content);
            MapProperty(x => x.Image);
        }

        public override string TemplatePath
        {
            get { return "Aqueduct/Fake/Template"; }
        }

        public override bool SkipTemplateChecking
        {
            get { return true; }
        }
    }
}
