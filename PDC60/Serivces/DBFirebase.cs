using PDC60.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;

namespace PDC60.Serivces
{
    //Like I said, di man lahat ng parameters andito. Hehe!
    public class DBFirebase
    {
        FirebaseClient client;
        public DBFirebase()
        {
            //Lagay mo yung sayo. HAHAHAHHA!
            client = new FirebaseClient("");
        }

        public ObservableCollection<Tree> getTree()
        {
            var TreeData = client
                .Child("Tree")
                .AsObservable<Tree>()
                .AsObservableCollection();

            return TreeData;
        }
        public async Task AddTree(int Id, string Name, string TreeCode, string Identification, string Notes,
                                  string Landmark, string TrunkFlare, double Height, double DMB, string SurfaceRoots, string Canopy)
        {
            Tree em = new Tree()
            {
                Id = Id,
                Name = Name,
                TreeCode = TreeCode,
                Identification = Identification,
                Notes = Notes,
                Landmark = Landmark,
                TrunkFlare = TrunkFlare,
                Height = Height,
                DMB = DMB,
                SurfaceRoots = SurfaceRoots,
                Canopy = Canopy
            };
            await client
                .Child("Tree")
                .PostAsync(em);
        }
        public async Task DeleteTree(int Id, string Name, string TreeCode, string Identification, string Notes,
                                     string Landmark, string TrunkFlare, double Height, double DMB, string SurfaceRoots, string Canopy)
        {
            var toDeleteTree = (await client
                .Child("Tree")
                .OnceAsync<Tree>()).FirstOrDefault
                (a => a.Object.name == Name || a.Object.treecode == TreeCode);

            await client.Child("Tree").Child(toDeleteTree.Key).DeleteAsync();
        }
        public async Task UpdateTree(int Id, string Name, string TreeCode, string Identification, string Notes,
                                     string Landmark, string TrunkFlare, double Height, double DMB, string SurfaceRoots, string Canopy)
        {
            var toUpdateTree = (await client
                .Child("Tree")
                .OnceAsync<Tree>()).FirstOrDefault
                (a => a.Object.name == Name);

            Tree t = new Tree()
            {
                Id = Id,
                Name = Name,
                TreeCode = TreeCode,
                Identification = Identification,
                Notes = Notes,
                Landmark = Landmark,
                TrunkFlare = TrunkFlare,
                Height = Height,
                DMB = DMB,
                SurfaceRoots = SurfaceRoots,
                Canopy = Canopy
            };
            await client
                .Child("Tree")
                .Child(toUpdateTree.Key)
                .PutAsync(t);
        }
    }
}
