// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace A_WEAR_CULTURE.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using A_WEAR_CULTURE.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using A_WEAR_CULTURE.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using A_WEAR_CULTURE.Shared;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 206 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/Shared/ProductList.razor"
 
    //==========================================================

    // Product All Shared
    static string productDesigner = "designed by culture-A-wear";
    static string base_Color = "BLACK";
    static decimal base_RegPrice = 24.99m;
    static string promoDescription = "Halloween Sale";

    //==========================================================

    // Product 01
    static int tech01_ProductID = 1;
    static int tech01_CategoryID = 1;
    static string tech01_ImageURL = "img/tee_01/snap_01.png";
    static string tech01_ProductName = "Lucky AF";
    static string tech01_CodeName = "Codename: Techwear 07-AF";
    static string tech01_ProductColor = base_Color;
    static decimal tech01_RegPrice = 39.99m;
    static decimal tech01_PromoRate = 0m;
    static decimal tech01_PromoPrice = decimal.Round(tech01_RegPrice - (tech01_RegPrice * tech01_PromoRate), 2, MidpointRounding.AwayFromZero);
    static decimal tech01_PromoPercentage = decimal.Round(tech01_PromoRate * 100, 0, MidpointRounding.AwayFromZero);
    static string tech01_PromoDescription = $"{tech01_PromoPercentage}% Off {promoDescription}!";

    static string tech01_Desc =
        $"Design inspired by the rise of Techwear in pop culture. In the distopian future, " +
        "a bit of luck can mean life and death. " +
        "The stylized number 07 is believed to be lucky in most parts of the world, " +
        "and the abbreviated version of the current meme trend that means something is 'Next Level', " +
        "could be interpreted as being " +
        "futuristic gothic fashion with trench coats, boots, and black clothing. " +
        "The alt style pays homage to the gritty urban dystopian future found in " +
        "science fiction and anime films like Johnny Mnemonic, The Matrix, Blade Runner, " +
        "Aeon Flux, Akira, and Ghost in the Shell. It became a full-fledged fashion genre " +
        "in the late 1980s and " +
        "continues to increase in popularity as the reality we are living in inches closer " +
        "to the dystopia in films." +
        "<br><br>" +

        "+ Designed and Printed in the U.S.A. <br>" +
        "+ Blacked-Out | Ribbed Collar | High-Quality Tee <br>" +
        "+ Material: 100% Ringspun Cotton";

    static string[] tech01_ProductIntro = tech01_Desc.Split(' ');
    static string tech01_shortIntro = shortensIntro(tech01_ProductIntro);

    //==========================================================

    // Product 02
    static int tech02_ProductID = 2;
    static int tech02_CategoryID = 1;
    static string tech02_ImageURL = "img/tee_02/snap_01.png";
    static string tech02_ProductName = "Danger Agent";
    static string tech02_CodeName = "Codename: Techwear 00-DANG-37";
    static string tech02_ProductColor = base_Color;
    static decimal tech02_RegPrice = base_RegPrice;
    static decimal tech02_PromoRate = 0.20m;
    static decimal tech02_PromoPrice = decimal.Round(tech02_RegPrice - (tech02_RegPrice * tech02_PromoRate), 2, MidpointRounding.AwayFromZero);
    static decimal tech02_PromoPercentage = decimal.Round(tech02_PromoRate * 100, 0, MidpointRounding.AwayFromZero);
    static string tech02_PromoDescription = $"{tech02_PromoPercentage}% Off {promoDescription}!";

    static string tech02_Desc =
        "Design inspired by the iconic pop culture spy-movie genre known for its " +
        "dangerous action sequences. The 'Double-00' agent code meshed " +
        "with a stylization of the word 'DANGER' creates a unique design aesthetic, " +
        "with a touch of the technical aspects of a dark distopia. " +
        "Techwear represents tactical, futuristic fashion that can be easily identified " +
        "by trench coats, boots, and black clothing that pervades deep into Pop Culture. " +
        "The alt style pays homage to the gritty urban dystopian future found in " +
        "science fiction and anime films like Johnny Mnemonic, The Matrix, Blade Runner, " +
        "Aeon Flux, Akira, and Ghost in the Shell. It became a full-fledged fashion genre " +
        "in the late 1980s and " +
        "continues to increase in popularity as the reality we are living in inches closer " +
        "to the dystopia in films." +
        "<br><br>" +

        "+ Designed and Printed in the U.S.A. <br>" +
        "+ Blacked-Out | Ribbed Collar | High-Quality Tee <br>" +
        "+ Material: 100% Ringspun Cotton";

    static string[] tech02_ProductIntro = tech02_Desc.Split(' ');
    static string tech02_shortIntro = shortensIntro(tech02_ProductIntro);

    //==========================================================

    // Product 03
    static int tech03_ProductID = 3;
    static int tech03_CategoryID = 1;
    static string tech03_ImageURL = "img/tee_03/snap_01.png";
    static string tech03_ProductName = "Toxic AF";
    static string tech03_CodeName = "Codename: Techwear TOX-105-AF";
    static string tech03_ProductColor = base_Color;
    static decimal tech03_RegPrice = 29.99m;
    static decimal tech03_PromoRate = 0.17m;
    static decimal tech03_PromoPrice = decimal.Round(tech03_RegPrice - (tech03_RegPrice * tech03_PromoRate), 2, MidpointRounding.AwayFromZero);
    static decimal tech03_PromoPercentage = decimal.Round(tech03_PromoRate * 100, 0, MidpointRounding.AwayFromZero);
    static string tech03_PromoDescription = $"{tech03_PromoPercentage}% Off {promoDescription}!";

    static string tech03_Desc =
        "Design inspired by the abbreviated, stylized word for Technical Wear " +
        "melded with a 'Toxic' character and the way to 'Level Up' in today's favorite pop culture game. " +
        "Techwear represents tactical, futuristic fashion that can be easily identified " +
        "by trench coats, boots, and black clothing that pervades deep into Pop Culture. " +
        "The alt style pays homage to the gritty urban dystopian future found in " +
        "science fiction and anime films like Johnny Mnemonic, The Matrix, Blade Runner, " +
        "Aeon Flux, Akira, and Ghost in the Shell. It became a full-fledged fashion genre " +
        "in the late 1980s and " +
        "continues to increase in popularity as the reality we are living in inches closer " +
        "to the dystopia in films." +
        "<br><br>" +

        "+ Designed and Printed in the U.S.A. <br>" +
        "+ Blacked-Out | Ribbed Collar | High-Quality Tee <br>" +
        "+ Material: 100% Ringspun Cotton";

    static string[] tech03_ProductIntro = tech03_Desc.Split(' ');
    static string tech03_shortIntro = shortensIntro(tech03_ProductIntro);

    //==========================================================

    // Product 04
    static int tech04_ProductID = 4;
    static int tech04_CategoryID = 1;
    static string tech04_ImageURL = "img/tee_04/snap_01.png";
    static string tech04_ProductName = "Dead End";
    static string tech04_CodeName = "Codename: Techwear COD-X-12-21";
    static string tech04_ProductColor = base_Color;
    static decimal tech04_RegPrice = 34.99m;
    static decimal tech04_PromoRate = 0.17m;
    static decimal tech04_PromoPrice = decimal.Round(tech04_RegPrice - (tech04_RegPrice * tech04_PromoRate), 2, MidpointRounding.AwayFromZero);
    static decimal tech04_PromoPercentage = decimal.Round(tech04_PromoRate * 100, 0, MidpointRounding.AwayFromZero);
    static string tech04_PromoDescription = $"{tech04_PromoPercentage}% Off {promoDescription}!";

    static string tech04_Desc =
        "Design inspired by the Maya Calendar and Codex, aka the Mayan Codex of Mexico " +
        "previously known as the Grolier Codex. According to pop culture myth, " +
        "the 'End of World' is almost here predicted to come December 21st. " +
        "Techwear represents tactical, futuristic fashion that can be easily identified " +
        "by trench coats, boots, and black clothing that pervades deep into Pop Culture. " +
        "The alt style pays homage to the gritty urban dystopian future found in " +
        "science fiction and anime films like Johnny Mnemonic, The Matrix, Blade Runner, " +
        "Aeon Flux, Akira, and Ghost in the Shell. It became a full-fledged fashion genre " +
        "in the late 1980s and " +
        "continues to increase in popularity as the reality we are living in inches closer " +
        "to the dystopia in films." +
        "<br><br>" +

        "+ Designed and Printed in the U.S.A. <br>" +
        "+ Blacked-Out | Ribbed Collar | High-Quality Tee <br>" +
        "+ Material: 100% Ringspun Cotton";

    static string[] tech04_ProductIntro = tech04_Desc.Split(' ');
    static string tech04_shortIntro = shortensIntro(tech04_ProductIntro);

    //==========================================================

    // Product 05
    static int tech05_ProductID = 5;
    static int tech05_CategoryID = 1;
    static string tech05_ImageURL = "img/tee_05/snap_01.png";
    static string tech05_ProductName = "Fire In Progress";
    static string tech05_CodeName = "Codename: Techwear FI-82-RE";
    static string tech05_ProductColor = base_Color;
    static decimal tech05_RegPrice = 39.99m;
    static decimal tech05_PromoRate = 0m;
    static decimal tech05_PromoPrice = decimal.Round(tech05_RegPrice - (tech05_RegPrice * tech05_PromoRate), 2, MidpointRounding.AwayFromZero);
    static decimal tech05_PromoPercentage = decimal.Round(tech05_PromoRate * 100, 0, MidpointRounding.AwayFromZero);
    static string tech05_PromoDescription = $"{tech05_PromoPercentage}% Off {promoDescription}!";

    static string tech05_Desc =
        "Design inspired by the abbreviated, stylized word for Technical Wear " +
        "combined with what Tactical Units often refer to as Ten-Dash (10-) Codes, " +
        "and the stylized word that is trending all over the internet meaning 'Totally Awesome' " +
        "Techwear represents tactical, futuristic fashion that can be easily identified " +
        "by trench coats, boots, and black clothing that pervades deep into Pop Culture. " +
        "The alt style pays homage to the gritty urban dystopian future found in " +
        "science fiction and anime films like Johnny Mnemonic, The Matrix, Blade Runner, " +
        "Aeon Flux, Akira, and Ghost in the Shell. It became a full-fledged fashion genre " +
        "in the late 1980s and " +
        "continues to increase in popularity as the reality we are living in inches closer " +
        "to the dystopia in films." +
        "<br><br>" +

        "+ Designed and Printed in the U.S.A. <br>" +
        "+ Blacked-Out | Ribbed Collar | High-Quality Tee <br>" +
        "+ Material: 100% Ringspun Cotton";

    static string[] tech05_ProductIntro = tech05_Desc.Split(' ');
    static string tech05_shortIntro = shortensIntro(tech05_ProductIntro);

    //==========================================================

    // Product 06
    static int tech06_ProductID = 6;
    static int tech06_CategoryID = 1;
    static string tech06_ImageURL = "img/tee_06/snap_01.png";
    static string tech06_ProductName = "Spooky Spider Slither";
    static string tech06_CodeName = "Codename: HALLOWEEN-2021-SPDR";
    static string tech06_ProductColor = base_Color;
    static decimal tech06_RegPrice = 34.99m;
    static decimal tech06_PromoRate = 0.10m;
    static decimal tech06_PromoPrice = decimal.Round(tech06_RegPrice - (tech06_RegPrice * tech06_PromoRate), 2, MidpointRounding.AwayFromZero);
    static decimal tech06_PromoPercentage = decimal.Round(tech06_PromoRate * 100, 0, MidpointRounding.AwayFromZero);
    static string tech06_PromoDescription = $"{tech06_PromoPercentage}% Off {promoDescription}!";

    static string tech06_Desc =
        "Design inspired by the Day of the Dead holiday motifs, notably scary spiders. " +
        "Halloween cobwebs are instantly recognizable historically in pop culture. " +
        "Since the 16th century, when the Spaniards arrived in central Mexico about 3,000 years ago, " +
        "the Aztecs were forced to adopt, what was thought of at the time to be sacrilegious, " +
        "the spooky tradition. " +
        "Over time, the main reason that spiders are linked with Halloween is their connection with " +
        "witches. Spiders, along with black cats and rats were believed to be evil companions of " +
        "witches in medieval times. " +
        "To add to this, the iconic landmarks associated with Halloween such as " +
        "haunted houses, graveyards, dungeons and creepy caves, all come fully stocked with an array of " +
        "spiders and spider webs. This is because, generally, spiders prefer to dwell in dark places. " +
        "On top of the scary connotations of spiders, in many countries around the world spiders were regarded " +
        "as mystical creatures due to their web-making abilities! In folklore, they are described as " +
        "storytellers and oracles of fate, wealth, and sometimes death." +
        "<br><br>" +

        "+ Designed and Printed in the U.S.A. <br>" +
        "+ Blacked-Out | Ribbed Collar | High-Quality Tee <br>" +
        "+ Material: 100% Ringspun Cotton";

    static string[] tech06_ProductIntro = tech06_Desc.Split(' ');
    static string tech06_shortIntro = shortensIntro(tech06_ProductIntro);

    // Product 07
    static int tech07_ProductID = 7;
    static int tech07_CategoryID = 1;
    static string tech07_ImageURL = "img/tee_07/snap_01.png";
    static string tech07_ProductName = "Bloody Bat Biter";
    static string tech07_CodeName = "Codename: HALLOWEEN-2021-BATT";
    static string tech07_ProductColor = base_Color;
    static decimal tech07_RegPrice = 35.99m;
    static decimal tech07_PromoRate = 0.12m;
    static decimal tech07_PromoPrice = decimal.Round(tech07_RegPrice - (tech07_RegPrice * tech07_PromoRate), 2, MidpointRounding.AwayFromZero);
    static decimal tech07_PromoPercentage = decimal.Round(tech07_PromoRate * 100, 0, MidpointRounding.AwayFromZero);
    static string tech07_PromoDescription = $"{tech07_PromoPercentage}% Off {promoDescription}!";

    static string tech07_Desc =
        "Design inspired by the spookiest and most enduring images of Halloween. Bats. " +
        "During the horrific holiday season, bats have taken hold evoking the scariest manifestation of pop culture. " +
        "Made popular by the vampire fiction Bram Stoker's 1897 novel 'Dracula' where " +
        "Vampires can turn into bats at will. Taken from the book, '... thought it well to know " +
        "if possible where the Count would go when he left the house. I did not see him, " +
        "but I saw a bat rise from Renfield's window and flap westward.' " +
        "The black, winged shapes flying through the dusky night sky are eternally linked to Halloween. " +
        "It may have started long ago, when the ancient Celtics lit large bonfires as " +
        "darkness approached to ward off the evil spirits of the night. According to the legends, " +
        "the Celtics believed the ghosts of their ancestors returned to earth once each year on " +
        "the night of October 31st when the spirits of the dead could cross over into the world of the living. " +
        "For centuries, tales and rumors of blood-sucking bats spread throughout Europe. " +
        "The evil images of a winged demon stalked the night to prey on the blood of " +
        "unsuspecting victims while they slept, fit perfectly into the dark lore of Halloween." +
        "<br><br>" +

        "+ Designed and Printed in the U.S.A. <br>" +
        "+ Blacked-Out | Ribbed Collar | High-Quality Tee <br>" +
        "+ Material: 100% Ringspun Cotton";

    static string[] tech07_ProductIntro = tech07_Desc.Split(' ');
    static string tech07_shortIntro = shortensIntro(tech07_ProductIntro);

    // Product 08
    static int tech08_ProductID = 8;
    static int tech08_CategoryID = 1;
    static string tech08_ImageURL = "img/tee_08/snap_01.png";
    static string tech08_ProductName = "Horribly Haunted House";
    static string tech08_CodeName = "Codename: HALLOWEEN-2021-HOUS";
    static string tech08_ProductColor = base_Color;
    static decimal tech08_RegPrice = 30.49m;
    static decimal tech08_PromoRate = 0.19m;
    static decimal tech08_PromoPrice = decimal.Round(tech08_RegPrice - (tech08_RegPrice * tech08_PromoRate), 2, MidpointRounding.AwayFromZero);
    static decimal tech08_PromoPercentage = decimal.Round(tech08_PromoRate * 100, 0, MidpointRounding.AwayFromZero);
    static string tech08_PromoDescription = $"{tech08_PromoPercentage}% Off {promoDescription}!";

    static string tech08_Desc =
        "Design inspired by Haunted Houses, Spook Houses or Ghost Houses. " +
        "Burned into pop culture's minds and made famous by The Amityville Horror, a 1977 cult classic. " +
        "According to historians, hauntings are usually associated with " +
        "ghostly or supernatural encounters. In other cultures " +
        "around the world, various spirits are said to haunt vacant homes and locations. " +
        "Historically, since most people died in their homes, " +
        "whether they were mansions or hovels, these homes became natural places for ghosts to haunt, " +
        "with bedrooms being the most common rooms to be haunted. Many houses gained a reputation for being " +
        "haunted after they were empty or derelict. It was widely thought that '...if people were to fail to " +
        "occupy a human space, then external forces would move in'. " +
        "In ghostlore haunted houses are often perceived as being inhabited by disembodied spirits of the " +
        "deceased who may have been former residents or were otherwise connected with the property. " +
        "Parapsychologists often attribute haunting to the spirits of the dead who have suffered from violent or " +
        "tragic events in the building's past such as murder, accidental death, or suicide." +
        "<br><br>" +

        "+ Designed and Printed in the U.S.A. <br>" +
        "+ Blacked-Out | Ribbed Collar | High-Quality Tee <br>" +
        "+ Material: 100% Ringspun Cotton";

    static string[] tech08_ProductIntro = tech08_Desc.Split(' ');
    static string tech08_shortIntro = shortensIntro(tech08_ProductIntro);

    //==========================================================

    public static bool flippedFront;
    public static bool flippedBack;
    public string errorMessage { get; set; }

    public async void FlipMe(int i)
    {
        try
        {
            //flipped = !flipped;

            flippedFront = await JSRuntime.InvokeAsync<bool>("isCardFrontFlipped", i);

            if (!flippedFront)
            {
                await JSRuntime.InvokeAsync<object>("addClassToCardElement", i);
            }
            else
            {
                await JSRuntime.InvokeAsync<object>("removeClassToCardElement", i);
            }


            flippedBack = await JSRuntime.InvokeAsync<bool>("isCardBackFlipped", i);

            if (!flippedBack)
            {
                await JSRuntime.InvokeAsync<object>("addClassToCardBack", i);
            }
            else
            {
                await JSRuntime.InvokeAsync<object>("removeClassToCardBack", i);
            }
        }
        catch (JSException ex)
        {
            errorMessage = ex.Message;
        }
    }

    //Product Description on the Card Front needs to be shortened
    public static string shortensIntro(string[] arrIntro)
    {
        string shortIntro = "";
        int numberOfWords = 31;

        for (var i = 0; i < numberOfWords; i++)
        {
            shortIntro += arrIntro[i] + " ";
        }

        return shortIntro;
    }

    public async void OnButtonClick()
    {
        await JSRuntime.InvokeVoidAsync("topFunction");
    }


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 582 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/Shared/ProductList.razor"
       

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("changeImg");
        }
    }



    //List of products
    public static List<Product> products = new List<Product>
{
        new Product
        {
            ProductID = tech01_ProductID,
            CategoryID = tech01_CategoryID,
            ProductImage = tech01_ImageURL,
            ProductName = tech01_ProductName,
            CodeName = tech01_CodeName,
            ProductDesigner = productDesigner,
            ProductDescription = tech01_shortIntro,
            ProductDescriptionFull = tech01_Desc,
            ProductColor = tech01_ProductColor,
            ProductPrice = tech01_RegPrice,
            PromotionDescription = tech01_PromoDescription,
            PromotionPrice = tech01_PromoPrice
        },
        new Product
        {
            ProductID = tech02_ProductID,
            CategoryID = tech02_CategoryID,
            ProductImage = tech02_ImageURL,
            ProductName = tech02_ProductName,
            CodeName = tech02_CodeName,
            ProductDesigner = productDesigner,
            ProductDescription = tech02_shortIntro,
            ProductDescriptionFull = tech02_Desc,
            ProductColor = tech02_ProductColor,
            ProductPrice = tech02_RegPrice,
            PromotionDescription = tech02_PromoDescription,
            PromotionPrice = tech02_PromoPrice
        },
        new Product
        {
            ProductID = tech03_ProductID,
            CategoryID = tech03_CategoryID,
            ProductImage = tech03_ImageURL,
            ProductName = tech03_ProductName,
            CodeName = tech03_CodeName,
            ProductDesigner = productDesigner,
            ProductDescription = tech03_shortIntro,
            ProductDescriptionFull = tech03_Desc,
            ProductColor = tech03_ProductColor,
            ProductPrice = tech03_RegPrice,
            PromotionDescription = tech03_PromoDescription,
            PromotionPrice = tech03_PromoPrice
        },
        new Product
        {
            ProductID = tech04_ProductID,
            CategoryID = tech04_CategoryID,
            ProductImage = tech04_ImageURL,
            ProductName = tech04_ProductName,
            CodeName = tech04_CodeName,
            ProductDesigner = productDesigner,
            ProductDescription = tech04_shortIntro,
            ProductDescriptionFull = tech04_Desc,
            ProductColor = tech04_ProductColor,
            ProductPrice = tech04_RegPrice,
            PromotionDescription = tech04_PromoDescription,
            PromotionPrice = tech04_PromoPrice
        },
        new Product
        {
            ProductID = tech05_ProductID,
            CategoryID = tech05_CategoryID,
            ProductImage = tech05_ImageURL,
            ProductName = tech05_ProductName,
            CodeName = tech05_CodeName,
            ProductDesigner = productDesigner,
            ProductDescription = tech05_shortIntro,
            ProductDescriptionFull = tech05_Desc,
            ProductColor = tech05_ProductColor,
            ProductPrice = tech05_RegPrice,
            PromotionDescription = tech05_PromoDescription,
            PromotionPrice = tech05_PromoPrice
        },
        new Product
        {
            ProductID = tech06_ProductID,
            CategoryID = tech06_CategoryID,
            ProductImage = tech06_ImageURL,
            ProductName = tech06_ProductName,
            CodeName = tech06_CodeName,
            ProductDesigner = productDesigner,
            ProductDescription = tech06_shortIntro,
            ProductDescriptionFull = tech06_Desc,
            ProductColor = tech06_ProductColor,
            ProductPrice = tech06_RegPrice,
            PromotionDescription = tech06_PromoDescription,
            PromotionPrice = tech06_PromoPrice
        },
        new Product
        {
            ProductID = tech07_ProductID,
            CategoryID = tech07_CategoryID,
            ProductImage = tech07_ImageURL,
            ProductName = tech07_ProductName,
            CodeName = tech07_CodeName,
            ProductDesigner = productDesigner,
            ProductDescription = tech07_shortIntro,
            ProductDescriptionFull = tech07_Desc,
            ProductColor = tech07_ProductColor,
            ProductPrice = tech07_RegPrice,
            PromotionDescription = tech07_PromoDescription,
            PromotionPrice = tech07_PromoPrice
        },
        new Product
        {
            ProductID = tech08_ProductID,
            CategoryID = tech08_CategoryID,
            ProductImage = tech08_ImageURL,
            ProductName = tech08_ProductName,
            CodeName = tech08_CodeName,
            ProductDesigner = productDesigner,
            ProductDescription = tech08_shortIntro,
            ProductDescriptionFull = tech08_Desc,
            ProductColor = tech08_ProductColor,
            ProductPrice = tech08_RegPrice,
            PromotionDescription = tech08_PromoDescription,
            PromotionPrice = tech08_PromoPrice
        }

    };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
