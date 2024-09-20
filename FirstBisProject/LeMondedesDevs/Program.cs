using LeMondedesDevs;


Developer dev = new();
LeadDev leadDev = new();
Chef chef = new();

dev.CodeFini += chef.CroireLireLeCode;
dev.CodeFini += leadDev.EtudierLeCodeDUnDev;

dev.Ecrire();


using (Chef chef2 = new())
{

}