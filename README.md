
## About the Project

This project is an example of how the IntersectionObserver WebApi can be used in the context of a Blazor Application. The project uses the <a href="https://github.com/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator">canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator</a> project tool to generate a Blazor Interop Abstraction around the JavaScript calls that would be used to call Api. 

This project is currenlty setup for Blazor Wasm, but the source can be generated to also work in a Blazor server context, checkout the documentation on the <a href="https://github.com/canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator/blob/main/Tool/EventHorizon.Blazor.TypeScript.Interop.Tool/README.md">canhorn/EventHorizon.Blazor.TypeScript.Interop.Generator Tool README</a> for more details on how to change the Source Generation options.

## Commands

You can use the command below to Regenerate the Blazor.WebApi.IntersectionObserver Source code. The <a href="./GeneratorSource/IntersectionObserver.d.ts">IntersectionObserver.d.ts</a> file is a TypeScript Definition of the relevent parts of the IntersectionObserver that can be used in the example project. Checkout the <a href="Generated/Blazor.WebApi.IntersectionObserver">Blazor.WebApi.IntersectionObserver</a> to see the generated source of the below command.

~~~ bash
# Generate 
ehz-generate -f -a Blazor.WebApi.IntersectionObserver -s ./GeneratorSource/IntersectionObserver.d.ts -c IntersectionObserver -l Generated
~~~
