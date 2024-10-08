# Tatil Planlayıcı / Holiday Planner

Bu uygulama, kullanıcının tercih ettiği bir tatil lokasyonu ve ulaşım türüne göre 3 günlük bir tatil için maliyet hesaplaması yapar. Kullanıcı, Bodrum, Marmaris veya Çeşme gibi popüler destinasyonlardan birini seçip, kaç kişi için plan yapacağını belirtir ve ulaşım tercihini yaparak toplam maliyeti öğrenebilir.

This application calculates the cost of a 3-day vacation based on the user's choice of destination and mode of transport. The user can select from popular destinations such as Bodrum, Marmaris, or Çeşme, specify the number of people, and choose the transportation type to calculate the total cost.

## Features / Özellikler

- **3 Lokasyon seçeneği:** Bodrum, Marmaris, Çeşme
- **Ulaşım seçenekleri:** Kara yolu ve Hava yolu
- **Kişi sayısına göre toplam maliyet hesaplama**

---

- **3 Location options:** Bodrum, Marmaris, Çeşme
- **Transport options:** Land (car) and Air (plane)
- **Total cost calculation based on number of people**

## Kullanım / Usage

1. Kullanıcıdan bir lokasyon seçmesi istenir (Bodrum, Marmaris veya Çeşme). Seçim yaparken büyük-küçük harf duyarlılığı yoktur.
2. Kaç kişi için tatil planlanacağı sorulur.
3. Kara yolu ya da hava yolu tercihi yapılır.
4. Seçimlere göre toplam maliyet hesaplanır ve kullanıcıya sunulur.
5. Kullanıcı başka bir tatil planlamak isteyip istemediğine karar verebilir. İstemiyorsa program sonlanır.

---

1. The user is prompted to select a location (Bodrum, Marmaris, or Çeşme). The selection is case-insensitive.
2. The user is asked how many people the vacation is planned for.
3. The user chooses between land or air transportation.
4. Based on the selections, the total cost is calculated and displayed to the user.
5. The user can decide whether to plan another vacation. If not, the program ends.

```bash

Lütfen gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris veya Çeşme
> Bodrum
Kaç kişi için tatil planlamak istiyorsunuz?
> 2
Nasıl bir ulaşım aracı seçmek istersiniz? 
1 - Kara yolu (1500 TL kişi başı) 
2 - Hava yolu (4000 TL kişi başı)
> 2

Bodrum lokasyonuna Hava yolu ile 2 kişi için toplam tatil maliyetiniz: 16000 TL

