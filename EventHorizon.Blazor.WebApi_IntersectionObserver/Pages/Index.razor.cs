using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace EventHorizon.Blazor.WebApi_IntersectionObserver.Pages
{
    public class IndexModel
        : ComponentBase
    {
        public ElementReference Parent { get; set; }
        public ElementReference Last { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!firstRender)
            {
                return;
            }
            var parent = await Parent.ToInteropElement();
            var last = await Last.ToInteropElement();

            var observer = new IntersectionObserver(
                new ActionCallback<IntersectionObserverEntry[], IntersectionObserver>(
                    (entries, other) =>
                    {
                        var intersectedEntries = entries.Where(a => a.isIntersecting);
                        foreach (var intersectedEntry in intersectedEntries)
                        {
                            Console.WriteLine(intersectedEntry.target.id, intersectedEntry.intersectionRatio);
                            last.innerHTML = intersectedEntry.target.id + " : " + intersectedEntry.intersectionRatio;
                        }
                        return Task.CompletedTask;
                    }
                ),
                new IntersectionObserverInitCachedEntity
                {
                    root = parent
                }
            );

            for (var i = 1; i <= 100; i++)
            {
                var child = EventHorizonBlazorInterop.FuncClass<Element>(
                    entity => new Element(entity),
                    new string[] { "document", "createElement" },
                    "div"
                ); // document.createElement('div');
                child.id = i.ToString();
                child.innerHTML = child.id;
                parent.appendChild(child);

                observer.observe(child);
            }
        }
    }

    public static class ElementExtensions
    {
        /// <summary>
        /// Takes in the Blazor ElementReference and convertes it into a class that the EventHorizon Interop can work with.
        /// </summary>
        public static async Task<Element> ToInteropElement(
            this ElementReference eleRef
        )
        {
            await EventHorizonBlazorInterop.RunScript(
                "toInteropElement",
                "window[`eleRef${$args.id}`] = $args.eleRef;",
                new { id = eleRef.Id, eleRef }
            );
            return EventHorizonBlazorInterop.GetClass<Element>(
                "window",
                $"eleRef{eleRef.Id}",
                entity => new Element(entity)
            );
        }
    }
}