/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using Microsoft.JSInterop;

public interface IntersectionObserverEntryInit : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IntersectionObserverEntryInitCachedEntity>))]
public class IntersectionObserverEntryInitCachedEntity : CachedEntityObject, IntersectionObserverEntryInit
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
        private DOMRectInitCachedEntity __boundingClientRect;
        public DOMRectInitCachedEntity boundingClientRect
        {
            get
            {
            if(__boundingClientRect == null)
            {
                __boundingClientRect = EventHorizonBlazorInterop.GetClass<DOMRectInitCachedEntity>(
                    this.___guid,
                    "boundingClientRect",
                    (entity) =>
                    {
                        return new DOMRectInitCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingClientRect;
            }
            set
            {
__boundingClientRect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundingClientRect",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intersectionRatio",
                    value
                );
            }
        }

        private DOMRectInitCachedEntity __intersectionRect;
        public DOMRectInitCachedEntity intersectionRect
        {
            get
            {
            if(__intersectionRect == null)
            {
                __intersectionRect = EventHorizonBlazorInterop.GetClass<DOMRectInitCachedEntity>(
                    this.___guid,
                    "intersectionRect",
                    (entity) =>
                    {
                        return new DOMRectInitCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __intersectionRect;
            }
            set
            {
__intersectionRect = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intersectionRect",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isIntersecting",
                    value
                );
            }
        }

        private DOMRectInitCachedEntity __rootBounds;
        public DOMRectInitCachedEntity rootBounds
        {
            get
            {
            if(__rootBounds == null)
            {
                __rootBounds = EventHorizonBlazorInterop.GetClass<DOMRectInitCachedEntity>(
                    this.___guid,
                    "rootBounds",
                    (entity) =>
                    {
                        return new DOMRectInitCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __rootBounds;
            }
            set
            {
__rootBounds = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rootBounds",
                    value
                );
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
            set
            {
__target = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "time",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IntersectionObserverEntryInitCachedEntity() : base() { }

        public IntersectionObserverEntryInitCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
