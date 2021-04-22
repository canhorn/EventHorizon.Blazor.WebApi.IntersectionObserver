/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using Microsoft.JSInterop;

public interface IntersectionObserverInit : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<IntersectionObserverInitCachedEntity>))]
public class IntersectionObserverInitCachedEntity : CachedEntityObject, IntersectionObserverInit
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
            set
            {
__root = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "root",
                    value
                );
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
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rootMargin",
                    value
                );
            }
        }

        
        public decimal threshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "threshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "threshold",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public IntersectionObserverInitCachedEntity() : base() { }

        public IntersectionObserverInitCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
