/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using Microsoft.JSInterop;

public interface DOMRectReadOnly : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<DOMRectReadOnlyCachedEntity>))]
public class DOMRectReadOnlyCachedEntity : CachedEntityObject, DOMRectReadOnly
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
        
        public decimal bottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "bottom"
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
        }

        
        public decimal left
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "left"
                );
            }
        }

        
        public decimal right
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "right"
                );
            }
        }

        
        public decimal top
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "top"
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
        }

        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
        }
    #endregion
    
    #region Constructor
        public DOMRectReadOnlyCachedEntity() : base() { }

        public DOMRectReadOnlyCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public CachedEntity toJSON()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toJSON" }
                }
            );
        }
    #endregion
}
