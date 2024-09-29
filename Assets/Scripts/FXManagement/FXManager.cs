using System;
using UnityEngine;
using PixelCrushers.DialogueSystem;
namespace FXManagement
{
    public class FXManager : MonoBehaviour
    {
        
        [SerializeField] private AudioClip aMB_Branches;
        [SerializeField] private AudioClip aMB_Chill;
        [SerializeField] private AudioClip aMB_Cracking;
        [SerializeField] private AudioClip aMB_Fountain;
        [SerializeField] private AudioClip aMB_Leaves;
        [SerializeField] private AudioClip aMB_Rain;
        [SerializeField] private AudioClip aMB_Wind;

        [SerializeField] private AudioClip iMP_Dusk;
        [SerializeField] private AudioClip iMP_First;
        [SerializeField] private AudioClip iMP_Second;
        [SerializeField] private AudioClip iMP_Third;

        [SerializeField] private AudioClip sFX_Angry;
        [SerializeField] private AudioClip sFX_Axe;
        [SerializeField] private AudioClip sFX_Bag;
        [SerializeField] private AudioClip sFX_Bingo;
        [SerializeField] private AudioClip sFX_Bite;
        [SerializeField] private AudioClip sFX_Boutique;
        [SerializeField] private AudioClip sFX_Brush;
        [SerializeField] private AudioClip sFX_Burning;
        [SerializeField] private AudioClip sFX_Chair;
        [SerializeField] private AudioClip sFX_Closing;
        [SerializeField] private AudioClip sFX_Creaking;
        [SerializeField] private AudioClip sFX_Desintegrate;
        [SerializeField] private AudioClip sFX_Dign;
        [SerializeField] private AudioClip sFX_Dress;
        [SerializeField] private AudioClip sFX_Flaping;
        [SerializeField] private AudioClip sFX_Flies;
        [SerializeField] private AudioClip sFX_Fly;
        [SerializeField] private AudioClip sFX_Folks;
        [SerializeField] private AudioClip sFX_Gasoline;
        [SerializeField] private AudioClip sFX_Hat;
        [SerializeField] private AudioClip sFX_Hearth;
        [SerializeField] private AudioClip sFX_Hoot;
        [SerializeField] private AudioClip sFX_Laugh;
        [SerializeField] private AudioClip sFX_Laughs;
        [SerializeField] private AudioClip sFX_Logs;
        [SerializeField] private AudioClip sFX_Match;
        [SerializeField] private AudioClip sFX_Metalic;
        [SerializeField] private AudioClip sFX_Murmurs;
        [SerializeField] private AudioClip sFX_Paper;
        [SerializeField] private AudioClip sFX_Pet;
        [SerializeField] private AudioClip sFX_Police;
        [SerializeField] private AudioClip sFX_Screech;
        [SerializeField] private AudioClip sFX_Slam;
        [SerializeField] private AudioClip sFX_Snugle;
        [SerializeField] private AudioClip sFX_Splat;
        [SerializeField] private AudioClip sFX_Trap;
        [SerializeField] private AudioClip sFX_Tree;
        [SerializeField] private AudioClip sFX_Unpleasent;
        [SerializeField] private AudioClip sFX_Weird;
        [SerializeField] private AudioClip sFX_Whispering;
        [SerializeField] private AudioClip sFX_Write;
        
        [SerializeField] private AudioClip stp_Backstore;
        [SerializeField] private AudioClip stp_Boutique;
        [SerializeField] private AudioClip stp_Forest;
        [SerializeField] private AudioClip stp_Running;
        [SerializeField] private AudioClip stp_Townsquare;

        [SerializeField] private AudioSource ambientFx;
        [SerializeField] private AudioSource impactFx;
        [SerializeField] private AudioSource sfx;
        [SerializeField] private AudioSource stepsFX;

        [SerializeField] private GameObject vfx_displayCase;
        [SerializeField] private GameObject vfx_fireParent;
        [SerializeField] private GameObject vfx_bloodFountain;
        [SerializeField] private GameObject vfx_tomato;
        [SerializeField] private GameObject vfx_incense;
        [SerializeField] private GameObject vfx_DrippingBlood;
        [SerializeField] private GameObject vfx_dusk1;
        [SerializeField] private GameObject vfx_dusk2;
        [SerializeField] private GameObject vfx_fog;
        [SerializeField] private GameObject vfx_fountain;
        [SerializeField] private GameObject vfx_inicio;
        [SerializeField] private GameObject vfx_jessie;
        [SerializeField] private GameObject vfx_lessCooperation;
        [SerializeField] private GameObject vfx_mirella;
        [SerializeField] private GameObject vfx_moreCooperation;
        [SerializeField] private GameObject vfx_neutralSelection;
        [SerializeField] private GameObject vfx_rain;
        [SerializeField] private GameObject vfx_treeLeaf;
        [SerializeField] private GameObject vfx_warningSmoke;
        [SerializeField] private GameObject vfx_plumas;
        [SerializeField] private GameObject vfx_sparklesGus;
        [SerializeField] private GameObject vfx_dusk3;
        [SerializeField] private GameObject vfx_gus;


        private void Start()
        {
            RegisterFx();
        }

        public void PlayAmbientFX(string aType)
        {
            switch (aType)
            {
                case "Branches":
                    ambientFx.clip = aMB_Branches;
                    break;
                case "Chill":
                    ambientFx.clip = aMB_Chill;
                    break;
                case "Cracking":
                    ambientFx.clip = aMB_Cracking;
                    break;
                case "Fountain":
                    ambientFx.clip = aMB_Fountain;
                    break;
                case "Leaves":
                    ambientFx.clip = aMB_Leaves;
                    break;
                case "Rain":
                    ambientFx.clip = aMB_Rain;
                    break;
                case "Wind":
                    ambientFx.clip = aMB_Wind;
                    break;
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(aType), aType, null);
                }
            }
            ambientFx.Play();
        }

        public void StopAmbientFX()
        {
            ambientFx.Stop();
        }
        public void PlayImpactFX(string iType)
        {
            switch (iType)
            {
                case "Dusk":
                    impactFx.clip = iMP_Dusk;
                    break;
                case "First":
                    impactFx.clip = iMP_First;
                    break;
                case "Second":
                    impactFx.clip = iMP_Second;
                    break;
                case "Third":
                    impactFx.clip = iMP_Third;
                    break;
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(iType), iType, null);
                }
            }
            impactFx.Play();
        }
        public void StopImpactFX()
        {
            impactFx.Stop();
        }
        public void PlaySFX(string sType)
        {
            switch (sType)
            {
                case "Angry":
                    sfx.clip = sFX_Angry;
                    break;
                case "Axe":
                    sfx.clip = sFX_Axe;
                    break;
                case "Bag":
                    sfx.clip = sFX_Bag;
                    break;
                case "Bingo":
                    sfx.clip =sFX_Bingo;
                    break;
               
                case "Bite":
                    sfx.clip = sFX_Bite;
                    break;
                case "Boutique":
                    sfx.clip = sFX_Boutique;
                    break;
                case "Brush":
                    sfx.clip =sFX_Brush;
                    break;
                
                case "Burning":
                    sfx.clip = sFX_Burning;
                    break;
                case "Chair":
                    sfx.clip = sFX_Chair;
                    break;
                case "Closing":
                    sfx.clip = sFX_Closing;
                    break;
                
                case "Creaking":
                    sfx.clip = sFX_Creaking;
                    break;
                case "Desintegrate":
                    sfx.clip = sFX_Desintegrate;
                    break;
                case "Dign":
                    sfx.clip = sFX_Dign;
                    break;
                
                case "Dress":
                    sfx.clip = sFX_Dress;
                    break;
                case "Flaping":
                    sfx.clip = sFX_Flaping;
                    break;
                case "Flies":
                    sfx.clip = sFX_Flies;
                    break;
                
                case "Fly":
                    sfx.clip = sFX_Fly;
                    break;
                case "Folks":
                    sfx.clip = sFX_Folks;
                    break;
                case "Gasoline":
                    sfx.clip = sFX_Gasoline;
                    break;
                case "Hat":
                    sfx.clip = sFX_Hat;
                    break;
                case "Hearth":
                    sfx.clip = sFX_Hearth;
                    break;
                case "Hoot":
                    sfx.clip = sFX_Hoot;
                    break;
                case "Laugh":
                    sfx.clip = sFX_Laugh;
                    break;
                case "Laughs":
                    sfx.clip = sFX_Laughs;
                    break;
                case "Logs":
                    sfx.clip = sFX_Logs;
                    break;
                case "Match":
                    sfx.clip = sFX_Match;
                    break;
                case "Metalic":
                    sfx.clip = sFX_Metalic;
                    break;
                case "Murmurs":
                    sfx.clip = sFX_Murmurs;
                    break;
                case "Paper":
                    sfx.clip = sFX_Paper;
                    break;
                case "Pet":
                    sfx.clip = sFX_Pet;
                    break;
                case "Police":
                    sfx.clip = sFX_Police;
                    break;
                case "Screech":
                    sfx.clip = sFX_Screech;
                    break;
                case "Slam":
                    sfx.clip = sFX_Slam;
                    break;
                case "Snugle":
                    sfx.clip = sFX_Snugle;
                    break;
                case "Splat":
                    sfx.clip = sFX_Splat;
                    break;
                case "Trap":
                    sfx.clip = sFX_Trap;
                    break;
                case "Tree":
                    sfx.clip = sFX_Tree;
                    break;
                case "Unpleasent":
                    sfx.clip = sFX_Unpleasent;
                    break;
                case "Weird":
                    sfx.clip = sFX_Weird;
                    break;
                case "Whispering":
                    sfx.clip = sFX_Whispering;
                    break;
                case "Write":
                    sfx.clip = sFX_Write;
                    break;

                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(sType), sType, null);
                }
            }
            sfx.Play();
        }
        public void StopSFX()
        {
            sfx.Stop();
        }
        public void PlayStepsFX(string sType)
        {
            switch (sType)
            {
                case "Backstore":
                    stepsFX.clip = stp_Backstore;
                    break;
                case "Boutique":
                    stepsFX.clip = stp_Boutique;
                    break;
                case "Forest":
                    stepsFX.clip = stp_Forest;
                    break;
                case "Running":
                    stepsFX.clip = stp_Running;
                    break;
                case "Townsquare":
                    stepsFX.clip = stp_Townsquare;
                    break;
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(sType), sType, null);
                }
            }
            stepsFX.Play();
        }
        public void StopStepsFX()
        {
            stepsFX.Stop();
        }
        public void PlayVFX(string vType)
        {
            StopVFX(vType);
            switch (vType)
            {
                case "displayCase":
                    vfx_displayCase.SetActive(true);
                    break;
                case "fireParent":
                    vfx_fireParent.SetActive(true);
                    break;
                case "bloodFountain":
                    vfx_bloodFountain.SetActive(true);
                    break;
                case "tomato":
                    vfx_tomato.SetActive(true);
                    break;
                case "incense":
                    vfx_incense.SetActive(true);
                    break;
                
                case "DrippingBlood":
                    vfx_DrippingBlood.SetActive(true);
                    break;
                case "dusk1":
                    vfx_dusk1.SetActive(true);
                    break;
                case "dusk2":
                    vfx_dusk2.SetActive(true);
                    break;
                case "fog":
                    vfx_fog.SetActive(true);
                    break;
                case "fountain":
                    vfx_fountain.SetActive(true);
                    break;
                case "inicio":
                    vfx_inicio.SetActive(true);
                    break;
                case "jessie":
                    vfx_jessie.SetActive(true);
                    break;
                case "lessCooperation":
                    vfx_lessCooperation.SetActive(true);
                    break;
                case "mirella":
                    vfx_mirella.SetActive(true);
                    break;
                case "moreCooperation":
                    vfx_moreCooperation.SetActive(true);
                    break;
                case "neutralSelection":
                    vfx_neutralSelection.SetActive(true);
                    break;
                case "rain":
                    vfx_rain.SetActive(true);
                    break;
                case "treeLeaf":
                    vfx_treeLeaf.SetActive(true);
                    break;
                case "warningSmoke":
                    vfx_warningSmoke.SetActive(true);
                    break;
                case "plumas":
                    vfx_plumas.SetActive(true);
                    break;
                case "sparklesGus":
                    vfx_sparklesGus.SetActive(true);
                    break;
                case "dusk3":
                    vfx_dusk3.SetActive(true);
                    break;
                case "gus":
                    vfx_gus.SetActive(true);
                    break;
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(vType), vType, null);


                }
            }
        }
        public void StopVFX(string vType)
        {
            switch (vType)
            {
                case "displayCase":
                    vfx_displayCase.SetActive(false);
                    break;
                case "fireParent":
                    vfx_fireParent.SetActive(false);
                    break;
                case "bloodFountain":
                    vfx_bloodFountain.SetActive(false);
                    break;
                case "tomato":
                    vfx_tomato.SetActive(false);
                    break;
                case "incense":
                    vfx_incense.SetActive(false);
                    break;
                
                case "DrippingBlood":
                    vfx_DrippingBlood.SetActive(false);
                    break;
                case "dusk1":
                    vfx_dusk1.SetActive(false);
                    break;
                case "dusk2":
                    vfx_dusk2.SetActive(false);
                    break;
                case "fog":
                    vfx_fog.SetActive(false);
                    break;
                case "fountain":
                    vfx_fountain.SetActive(false);
                    break;
                case "inicio":
                    vfx_inicio.SetActive(false);
                    break;
                case "jessie":
                    vfx_jessie.SetActive(false);
                    break;
                case "lessCooperation":
                    vfx_lessCooperation.SetActive(false);
                    break;
                case "mirella":
                    vfx_mirella.SetActive(false);
                    break;
                case "moreCooperation":
                    vfx_moreCooperation.SetActive(false);
                    break;
                case "neutralSelection":
                    vfx_neutralSelection.SetActive(false);
                    break;
                case "rain":
                    vfx_rain.SetActive(false);
                    break;
                case "treeLeaf":
                    vfx_treeLeaf.SetActive(false);
                    break;
                case "warningSmoke":
                    vfx_warningSmoke.SetActive(false);
                    break;
                case "plumas":
                    vfx_plumas.SetActive(false);
                    break;
                case "sparklesGus":
                    vfx_sparklesGus.SetActive(false);
                    break;
                case "dusk3":
                    vfx_dusk3.SetActive(false);
                    break;
                case "gus":
                    vfx_gus.SetActive(false);
                    break;
                case "all":
                    vfx_displayCase.SetActive(false);
                    vfx_fireParent.SetActive(false);
                    vfx_bloodFountain.SetActive(false);
                    vfx_tomato.SetActive(false);
                    vfx_incense.SetActive(false);
                    vfx_DrippingBlood.SetActive(false);
                    vfx_dusk1.SetActive(false);
                    vfx_dusk2.SetActive(false);
                    vfx_fog.SetActive(false);
                    vfx_fountain.SetActive(false);
                    vfx_inicio.SetActive(false);
                    vfx_jessie.SetActive(false);
                    vfx_lessCooperation.SetActive(false);
                    vfx_mirella.SetActive(false);
                    vfx_moreCooperation.SetActive(false);
                    vfx_neutralSelection.SetActive(false);
                    vfx_rain.SetActive(false);
                    vfx_treeLeaf.SetActive(false);
                    vfx_warningSmoke.SetActive(false);
                    vfx_plumas.SetActive(false);
                    vfx_sparklesGus.SetActive(false);
                    vfx_dusk3.SetActive(false);
                    vfx_gus.SetActive(false);
                    break;
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(vType), vType, null);


                }
            }
        }
        private void RegisterFx()
        {
            Lua.RegisterFunction("PlayAmbientFX", this, typeof(FXManager).GetMethod("PlayAmbientFX"));
            Lua.RegisterFunction("StopAmbientFX", this, typeof(FXManager).GetMethod("StopAmbientFX"));
            Lua.RegisterFunction("PlayImpactFX", this, typeof(FXManager).GetMethod("PlayImpactFX"));
            Lua.RegisterFunction("StopImpactFX", this, typeof(FXManager).GetMethod("StopImpactFX"));
            Lua.RegisterFunction("PlaySFX", this, typeof(FXManager).GetMethod("PlaySFX"));
            Lua.RegisterFunction("StopSFX", this, typeof(FXManager).GetMethod("StopSFX"));
            Lua.RegisterFunction("PlayStepsFX", this, typeof(FXManager).GetMethod("PlayStepsFX"));
            Lua.RegisterFunction("StopStepsFX", this, typeof(FXManager).GetMethod("StopStepsFX"));
            Lua.RegisterFunction("PlayVFX", this, typeof(FXManager).GetMethod("PlayVFX"));
            Lua.RegisterFunction("StopVFX", this, typeof(FXManager).GetMethod("StopVFX"));

        }
    }
}
