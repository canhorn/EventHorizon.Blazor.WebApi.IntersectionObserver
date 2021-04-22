/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<IntersectionObserverEntry>))]
public class IntersectionObserverEntry : CachedEntityObject
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
        private DOMRectReadOnlyCachedEntity __boundingClientRect;
        public DOMRectReadOnlyCachedEntity boundingClientRect
        {
            get
            {
            if(__boundingClientRect == null)
            {
                __boundingClientRect = EventHorizonBlazorInterop.GetClass<DOMRectReadOnlyCachedEntity>(
                    this.___guid,
                    "boundingClientRect",
                    (entity) =>
                    {
                        return new DOMRectReadOnlyCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingClientRect;
            }
        }

        
        public decimal intersectionRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intersectionRatio"
                );
            }
        }

        private DOMRectReadOnlyCachedEntity __intersectionRect;
        public DOMRectReadOnlyCachedEntity intersectionRect
        {
            get
            {
            if(__intersectionRect == null)
            {
                __intersectionRect = EventHorizonBlazorInterop.GetClass<DOMRectReadOnlyCachedEntity>(
                    this.___guid,
                    "intersectionRect",
                    (entity) =>
                    {
                        return new DOMRectReadOnlyCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __intersectionRect;
            }
        }

        
        public bool isIntersecting
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isIntersecting"
                );
            }
        }

        private DOMRectReadOnlyCachedEntity __rootBounds;
        public DOMRectReadOnlyCachedEntity rootBounds
        {
            get
            {
            if(__rootBounds == null)
            {
                __rootBounds = EventHorizonBlazorInterop.GetClass<DOMRectReadOnlyCachedEntity>(
                    this.___guid,
                    "rootBounds",
                    (entity) =>
                    {
                        return new DOMRectReadOnlyCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __rootBounds;
            }
        }

        private Element __target;
        public Element target
        {
            get
            {
            if(__target == null)
            {
                __target = EventHorizonBlazorInterop.GetClass<Element>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new Element() { ___guid = entity.___guid };
                    }
                );
            }
            return __target;
            }
        }

        
        public decimal time
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "time"
                );
            }
        }
    #endregion
    
    #region Constructor
        public IntersectionObserverEntry() : base() { }

        public IntersectionObserverEntry(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public IntersectionObserverEntry(
            IntersectionObserverEntryInit intersectionObserverEntryInit
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "IntersectionObserverEntry" },
                intersectionObserverEntryInit
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
