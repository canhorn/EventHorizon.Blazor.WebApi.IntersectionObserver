/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<Element>))]
public class Element : CachedEntityObject
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
        
        public string id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public string innerHTML
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "innerHTML"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "innerHTML",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public Element() : base() { }

        public Element(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


    #endregion

    #region Methods
        public void appendChild(Element child)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "appendChild" }, child
                }
            );
        }
    #endregion
}
