/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<IntersectionObserver>))]
public class IntersectionObserver : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        private Element __root;
        public Element root
        {
            get
            {
            if(__root == null)
            {
                __root = EventHorizonBlazorInterop.GetClass<Element>(
                    this.___guid,
                    "root",
                    (entity) =>
                    {
                        return new Element() { ___guid = entity.___guid };
                    }
                );
            }
            return __root;
            }
        }

        
        public string rootMargin
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "rootMargin"
                );
            }
        }

        
        public decimal thresholds
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "thresholds"
                );
            }
        }
    #endregion
    
    #region Constructor
        public IntersectionObserver() : base() { }

        public IntersectionObserver(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public IntersectionObserver(
            ActionCallback<IntersectionObserverEntry[], IntersectionObserver> callback, IntersectionObserverInit options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "IntersectionObserver" },
                callback, options
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        public void disconnect()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disconnect" }
                }
            );
        }

        public void observe(Element target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "observe" }, target
                }
            );
        }

        public IntersectionObserverEntry[] takeRecords()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IntersectionObserverEntry>(
                entity => new IntersectionObserverEntry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "takeRecords" }
                }
            );
        }

        public void unobserve(Element target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unobserve" }, target
                }
            );
        }
    #endregion
}
