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
        }
    }
}
