// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 10-23-2019
// ***********************************************************************
// <copyright file="Resources.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Tacoma_ProyectoDesarrollo.Properties
{


    /// <summary>
    /// Clase de recurso fuertemente tipado para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        /// <summary>
        /// The resource man
        /// </summary>
        private static global::System.Resources.ResourceManager resourceMan;

        /// <summary>
        /// The resource culture
        /// </summary>
        private static global::System.Globalization.CultureInfo resourceCulture;

        /// <summary>
        /// Initializes a new instance of the <see cref="Resources"/> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        /// Devuelve la instancia ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        /// <value>The resource manager.</value>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((resourceMan == null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tacoma_ProyectoDesarrollo.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        /// Invalida la propiedad CurrentUICulture del subproceso actual para todas las
        /// búsquedas de recursos usando esta clase de recursos fuertemente tipados.
        /// </summary>
        /// <value>The culture.</value>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
    }
}
