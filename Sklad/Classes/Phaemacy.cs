
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace sklad.Classes
{

using System;
    using System.Collections.Generic;
    
public partial class Phaemacy
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Phaemacy()
    {

        this.Application = new HashSet<Application>();

    }


    public int IDpharmacy { get; set; }

    public string NazvaniePharmacy { get; set; }

    public string PharmacyAddress { get; set; }

    public string PhonePharmacy { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Application> Application { get; set; }

}

}
