﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Koden er generert av et verktøy.
//     Kjøretidsversjon:4.0.30319.42000
//
//     Endringer i denne filen kan føre til feil virkemåte, og vil gå tapt hvis
//     koden genereres på nytt.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Folgebrev {
    
    private RettighetsHaver kreditorField;
    
    private RettighetsHaver[] debitorerField;
    
    private MatrikkelEnhet[] matrikkelEnheterField;
    
    private Pantedokument pantedokumentDetaljerField;
    
    private Overfoersel overfoerselDetaljerField;
    
    private string[] forutsetningerField;
    
    private string annenFritekstField;
    
    private Adresse returneresTilField;
    
    private Person avsenderField;
    
    private JuridiskPerson mottakerField;
    
    /// <remarks/>
    public RettighetsHaver Kreditor {
        get {
            return this.kreditorField;
        }
        set {
            this.kreditorField = value;
        }
    }
    
    /// <remarks/>
    public RettighetsHaver[] Debitorer {
        get {
            return this.debitorerField;
        }
        set {
            this.debitorerField = value;
        }
    }
    
    /// <remarks/>
    public MatrikkelEnhet[] MatrikkelEnheter {
        get {
            return this.matrikkelEnheterField;
        }
        set {
            this.matrikkelEnheterField = value;
        }
    }
    
    /// <remarks/>
    public Pantedokument PantedokumentDetaljer {
        get {
            return this.pantedokumentDetaljerField;
        }
        set {
            this.pantedokumentDetaljerField = value;
        }
    }
    
    /// <remarks/>
    public Overfoersel OverfoerselDetaljer {
        get {
            return this.overfoerselDetaljerField;
        }
        set {
            this.overfoerselDetaljerField = value;
        }
    }
    
    /// <remarks/>
    public string[] Forutsetninger {
        get {
            return this.forutsetningerField;
        }
        set {
            this.forutsetningerField = value;
        }
    }
    
    /// <remarks/>
    public string AnnenFritekst {
        get {
            return this.annenFritekstField;
        }
        set {
            this.annenFritekstField = value;
        }
    }
    
    /// <remarks/>
    public Adresse ReturneresTil {
        get {
            return this.returneresTilField;
        }
        set {
            this.returneresTilField = value;
        }
    }
    
    /// <remarks/>
    public Person Avsender {
        get {
            return this.avsenderField;
        }
        set {
            this.avsenderField = value;
        }
    }
    
    /// <remarks/>
    public JuridiskPerson Mottaker {
        get {
            return this.mottakerField;
        }
        set {
            this.mottakerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class RettighetsHaver {
    
    private string nummerField;
    
    private string navnField;
    
    /// <remarks/>
    public string Nummer {
        get {
            return this.nummerField;
        }
        set {
            this.nummerField = value;
        }
    }
    
    /// <remarks/>
    public string Navn {
        get {
            return this.navnField;
        }
        set {
            this.navnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class JuridiskPerson {
    
    private string navnField;
    
    private string organisasjonsnummerField;
    
    /// <remarks/>
    public string Navn {
        get {
            return this.navnField;
        }
        set {
            this.navnField = value;
        }
    }
    
    /// <remarks/>
    public string Organisasjonsnummer {
        get {
            return this.organisasjonsnummerField;
        }
        set {
            this.organisasjonsnummerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Person {
    
    private string navnField;
    
    private string emailField;
    
    private string telefonDirekteField;
    
    private string telefonField;
    
    /// <remarks/>
    public string Navn {
        get {
            return this.navnField;
        }
        set {
            this.navnField = value;
        }
    }
    
    /// <remarks/>
    public string Email {
        get {
            return this.emailField;
        }
        set {
            this.emailField = value;
        }
    }
    
    /// <remarks/>
    public string TelefonDirekte {
        get {
            return this.telefonDirekteField;
        }
        set {
            this.telefonDirekteField = value;
        }
    }
    
    /// <remarks/>
    public string Telefon {
        get {
            return this.telefonField;
        }
        set {
            this.telefonField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Adresse {
    
    private string navnField;
    
    private string postadresseField;
    
    private string postnummerField;
    
    private string poststedField;
    
    /// <remarks/>
    public string Navn {
        get {
            return this.navnField;
        }
        set {
            this.navnField = value;
        }
    }
    
    /// <remarks/>
    public string Postadresse {
        get {
            return this.postadresseField;
        }
        set {
            this.postadresseField = value;
        }
    }
    
    /// <remarks/>
    public string Postnummer {
        get {
            return this.postnummerField;
        }
        set {
            this.postnummerField = value;
        }
    }
    
    /// <remarks/>
    public string Poststed {
        get {
            return this.poststedField;
        }
        set {
            this.poststedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Overfoersel {
    
    private double beloepField;
    
    private System.DateTime beloepOverfortDatoField;
    
    private double totalBeloepField;
    
    private string tilKontonummerField;
    
    private string kIDField;
    
    private string kreditorSaksnummerField;
    
    private string meglerSaksnummerField;
    
    private string beloepGjelderField;
    
    private System.DateTime produsertDatoField;
    
    /// <remarks/>
    public double Beloep {
        get {
            return this.beloepField;
        }
        set {
            this.beloepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime BeloepOverfortDato {
        get {
            return this.beloepOverfortDatoField;
        }
        set {
            this.beloepOverfortDatoField = value;
        }
    }
    
    /// <remarks/>
    public double TotalBeloep {
        get {
            return this.totalBeloepField;
        }
        set {
            this.totalBeloepField = value;
        }
    }
    
    /// <remarks/>
    public string TilKontonummer {
        get {
            return this.tilKontonummerField;
        }
        set {
            this.tilKontonummerField = value;
        }
    }
    
    /// <remarks/>
    public string KID {
        get {
            return this.kIDField;
        }
        set {
            this.kIDField = value;
        }
    }
    
    /// <remarks/>
    public string KreditorSaksnummer {
        get {
            return this.kreditorSaksnummerField;
        }
        set {
            this.kreditorSaksnummerField = value;
        }
    }
    
    /// <remarks/>
    public string MeglerSaksnummer {
        get {
            return this.meglerSaksnummerField;
        }
        set {
            this.meglerSaksnummerField = value;
        }
    }
    
    /// <remarks/>
    public string BeloepGjelder {
        get {
            return this.beloepGjelderField;
        }
        set {
            this.beloepGjelderField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime ProdusertDato {
        get {
            return this.produsertDatoField;
        }
        set {
            this.produsertDatoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PrioritetsAngivelse {
    
    private PrioritetsRekkefolge rekkefolgeField;
    
    private RettighetsHaver panthaverField;
    
    private double beloepField;
    
    private string prioritetsBeskrivelseField;
    
    /// <remarks/>
    public PrioritetsRekkefolge Rekkefolge {
        get {
            return this.rekkefolgeField;
        }
        set {
            this.rekkefolgeField = value;
        }
    }
    
    /// <remarks/>
    public RettighetsHaver Panthaver {
        get {
            return this.panthaverField;
        }
        set {
            this.panthaverField = value;
        }
    }
    
    /// <remarks/>
    public double Beloep {
        get {
            return this.beloepField;
        }
        set {
            this.beloepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string PrioritetsBeskrivelse {
        get {
            return this.prioritetsBeskrivelseField;
        }
        set {
            this.prioritetsBeskrivelseField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
public enum PrioritetsRekkefolge {
    
    /// <remarks/>
    PrioritetEtter,
    
    /// <remarks/>
    PrioritetLikestiltMed,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Pantedokument {
    
    private double beloepField;
    
    private bool forstePrioritetField;
    
    private PrioritetsAngivelse[] prioritetField;
    
    /// <remarks/>
    public double Beloep {
        get {
            return this.beloepField;
        }
        set {
            this.beloepField = value;
        }
    }
    
    /// <remarks/>
    public bool ForstePrioritet {
        get {
            return this.forstePrioritetField;
        }
        set {
            this.forstePrioritetField = value;
        }
    }
    
    /// <remarks/>
    public PrioritetsAngivelse[] Prioritet {
        get {
            return this.prioritetField;
        }
        set {
            this.prioritetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatrikkelEnhet {
    
    private string kommuneNavnField;
    
    private string kommunenummerField;
    
    private string gardsnummerField;
    
    private string bruksnummerField;
    
    private string festenummerField;
    
    private string seksjonsnummerField;
    
    private string organisasjonsnummerField;
    
    private string andelsnummerField;
    
    private string borettslagNavnField;
    
    private string adresseField;
    
    public MatrikkelEnhet() {
        this.festenummerField = "0";
        this.seksjonsnummerField = "0";
    }
    
    /// <remarks/>
    public string KommuneNavn {
        get {
            return this.kommuneNavnField;
        }
        set {
            this.kommuneNavnField = value;
        }
    }
    
    /// <remarks/>
    public string Kommunenummer {
        get {
            return this.kommunenummerField;
        }
        set {
            this.kommunenummerField = value;
        }
    }
    
    /// <remarks/>
    public string Gardsnummer {
        get {
            return this.gardsnummerField;
        }
        set {
            this.gardsnummerField = value;
        }
    }
    
    /// <remarks/>
    public string Bruksnummer {
        get {
            return this.bruksnummerField;
        }
        set {
            this.bruksnummerField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string Festenummer {
        get {
            return this.festenummerField;
        }
        set {
            this.festenummerField = value;
        }
    }
    
    /// <remarks/>
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string Seksjonsnummer {
        get {
            return this.seksjonsnummerField;
        }
        set {
            this.seksjonsnummerField = value;
        }
    }
    
    /// <remarks/>
    public string Organisasjonsnummer {
        get {
            return this.organisasjonsnummerField;
        }
        set {
            this.organisasjonsnummerField = value;
        }
    }
    
    /// <remarks/>
    public string Andelsnummer {
        get {
            return this.andelsnummerField;
        }
        set {
            this.andelsnummerField = value;
        }
    }
    
    /// <remarks/>
    public string BorettslagNavn {
        get {
            return this.borettslagNavnField;
        }
        set {
            this.borettslagNavnField = value;
        }
    }
    
    /// <remarks/>
    public string Adresse {
        get {
            return this.adresseField;
        }
        set {
            this.adresseField = value;
        }
    }
}
