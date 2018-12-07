﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/3/2018 5:47:19 PM
namespace ODataVerificationService.Models
{
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    public partial class Container : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Movies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Movie> Movies
        {
            get
            {
                if ((this._Movies == null))
                {
                    this._Movies = base.CreateQuery<Movie>("Movies");
                }
                return this._Movies;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Movie> _Movies;
        /// <summary>
        /// There are no comments for Movies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToMovies(Movie movie)
        {
            base.AddObject("Movies", movie);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""ODataVerificationService.Models"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Movie"">
        <Key>
          <PropertyRef Name=""ID"" />
        </Key>
        <Property Name=""ID"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Title"" Type=""Edm.String"" />
        <Property Name=""Year"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""DueDate"" Type=""Edm.DateTimeOffset"" />
      </EntityType>
      <Action Name=""CheckOut"" IsBound=""true"">
        <Parameter Name=""bindingParameter"" Type=""ODataVerificationService.Models.Movie"" />
        <ReturnType Type=""ODataVerificationService.Models.Movie"" />
      </Action>
      <Action Name=""Return"" IsBound=""true"">
        <Parameter Name=""bindingParameter"" Type=""ODataVerificationService.Models.Movie"" />
        <ReturnType Type=""ODataVerificationService.Models.Movie"" />
      </Action>
      <Action Name=""CheckOutMany"" IsBound=""true"">
        <Parameter Name=""bindingParameter"" Type=""Collection(ODataVerificationService.Models.Movie)"" />
        <Parameter Name=""MovieIDs"" Type=""Collection(Edm.Int32)"" Nullable=""false"" />
        <ReturnType Type=""Collection(ODataVerificationService.Models.Movie)"" />
      </Action>
      <Action Name=""CreateMovie"">
        <Parameter Name=""Title"" Type=""Edm.String"" />
        <ReturnType Type=""ODataVerificationService.Models.Movie"" />
      </Action>
      <EntityContainer Name=""Container"">
        <EntitySet Name=""Movies"" EntityType=""ODataVerificationService.Models.Movie"" />
        <ActionImport Name=""CreateMovie"" Action=""ODataVerificationService.Models.CreateMovie"" EntitySet=""Movies"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    return global::Microsoft.OData.Edm.Csdl.CsdlReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
        /// <summary>
        /// There are no comments for CreateMovie in the schema.
        /// </summary>
        public global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie> CreateMovie(string Title)
        {
            return new global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie>(this, this.BaseUri.OriginalString.Trim('/') + "/CreateMovie", new global::Microsoft.OData.Client.BodyOperationParameter("Title", Title));
        }
    }
    /// <summary>
    /// There are no comments for MovieSingle in the schema.
    /// </summary>
    public partial class MovieSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Movie>
    {
        /// <summary>
        /// Initialize a new MovieSingle object.
        /// </summary>
        public MovieSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MovieSingle object.
        /// </summary>
        public MovieSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MovieSingle object.
        /// </summary>
        public MovieSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Movie> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Movie in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ID")]
    [global::Microsoft.OData.Client.EntitySet("Movies")]
    public partial class Movie : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Movie object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        /// <param name="year">Initial value of Year.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Movie CreateMovie(int ID, int year)
        {
            Movie movie = new Movie();
            movie.ID = ID;
            movie.Year = year;
            return movie;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
                this.OnPropertyChanged("ID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Year in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public int Year
        {
            get
            {
                return this._Year;
            }
            set
            {
                this.OnYearChanging(value);
                this._Year = value;
                this.OnYearChanged();
                this.OnPropertyChanged("Year");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _Year;
        partial void OnYearChanging(int value);
        partial void OnYearChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public global::System.Nullable<global::System.DateTimeOffset> DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<global::System.DateTimeOffset> _DueDate;
        partial void OnDueDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDueDateChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        /// <summary>
        /// There are no comments for CheckOut in the schema.
        /// </summary>
        public global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie> CheckOut()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie>(this.Context, resource.EditLink.OriginalString.Trim('/') + "/ODataVerificationService.Models.CheckOut");
        }
        /// <summary>
        /// There are no comments for Return in the schema.
        /// </summary>
        public global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie> Return()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie>(this.Context, resource.EditLink.OriginalString.Trim('/') + "/ODataVerificationService.Models.Return");
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::ODataVerificationService.Models.Movie as global::ODataVerificationService.Models.MovieSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::ODataVerificationService.Models.MovieSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataVerificationService.Models.Movie> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::ODataVerificationService.Models.MovieSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::ODataVerificationService.Models.Movie as global::ODataVerificationService.Models.MovieSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="iD">The value of iD</param>
        public static global::ODataVerificationService.Models.MovieSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataVerificationService.Models.Movie> source,
            int iD)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "ID", iD }
            };
            return new global::ODataVerificationService.Models.MovieSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// There are no comments for CheckOut in the schema.
        /// </summary>
        public static global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie> CheckOut(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::ODataVerificationService.Models.Movie> source)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie>(source.Context, source.AppendRequestUri("ODataVerificationService.Models.CheckOut"));
        }
        /// <summary>
        /// There are no comments for Return in the schema.
        /// </summary>
        public static global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie> Return(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::ODataVerificationService.Models.Movie> source)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuerySingle<global::ODataVerificationService.Models.Movie>(source.Context, source.AppendRequestUri("ODataVerificationService.Models.Return"));
        }
        /// <summary>
        /// There are no comments for CheckOutMany in the schema.
        /// </summary>
        public static global::Microsoft.OData.Client.DataServiceActionQuery<global::ODataVerificationService.Models.Movie> CheckOutMany(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataVerificationService.Models.Movie> source, global::System.Collections.Generic.ICollection<int> MovieIDs)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery<global::ODataVerificationService.Models.Movie>(source.Context, source.AppendRequestUri("ODataVerificationService.Models.CheckOutMany"), new global::Microsoft.OData.Client.BodyOperationParameter("MovieIDs", MovieIDs));
        }
    }
}
