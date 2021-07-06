An enhanced version of SotaJoe's original EASEncoder.
This enhanced version is written in C#.

## New features
This enhanced version offers new features that aren't in the original version of EASEncoder:
* Ability to encode EAS messages from raw data
* National location codes added
* Some planned features will be implemented, such as the ability to save EAS messages and import it for later use, the ability to decode EAS messages, the ability to change interface color.

## Build
1. Download or clone this repository.
2. Open the solution with Visual Studio 2019.
3. Right-click each of the projects in the solution and click "Manage NuGet Packages". If it shows any warning about missing NuGet Packages, follow the instructions to restore them.
4. Right-click the solution and click Rebuild Solution.

## EAS SAME protocol
According to Wikipedia,
> In the SAME system, messages are constructed in four parts, the first and last of which are digital and the middle two are audio. The digital sections of a SAME message are AFSK data bursts, with individual bits lasting 1920 μs (1.92 ms) each, giving a bit rate of 5205⁄6 bits per second. A mark bit is four complete cycles of a sine wave, translating to a mark frequency of 20831⁄3 Hz, and a space bit is three complete sine wave cycles, making the space frequency 1562.5 Hz.
>
> The data is sent isochronously and encoded in 8-bit bytes with the most-significant bit of each ASCII byte set to zero. The least-significant bit of each byte is transmitted first, including the preamble. The data stream is bit and byte synchronized on the preamble.
>
> Since there is no error correction, the digital part of a SAME message is transmitted three times, so that decoders can pick "best two out of three" for each byte, thereby eliminating most errors which can cause an activation to fail.

The text of an EAS message header code is a fixed format:

`<Preamble>ZCZC-ORG-EEE-PSSCCC+TTTT-JJJHHMM-LLLLLLLL-`

This is broken down as follows:
1. A preamble of binary 10101011 (0xAB in hex and « in ASCII) repeated sixteen times, used for "receiver calibration" (i.e., clock synchronization), then the letters ZCZC as an attention to the decoder (a message activation method inherited from NAVTEX).
2. ORG - Originator code, programmed per unit when put into operation:
    * PEP - Primary Entry Point System (President or other authorized national officials)
    * CIV - Civil Authorities (Governor, state/local emergency management, local police/fire officials)
    * WXR - National Weather Service or Environment Canada (Any weather-related alerts)
    * EAS - EAS Participant (Broadcasters, generally only used with test messages)
    * ~~EAN - Emergency Action Notification Network (previously used to send Emergency Action Notifications, no longer used)~~
3. EEE - Event code
4. PSSCCC — Location codes (up to 31 location codes per message), each beginning with a dash character; programmed at time of event
    * In the United States, the first digit (P) is zero if the entire county or area is included in the warning, otherwise, it is a non-zero number depending on the location of the emergency. The remaining five digits are the FIPS state (SS) and county code (CCC). The entire state may be specified by using county code 000 (three zeros).
    * In Canada, all six digits make up a Canadian Location Code, which corresponds to a specific forecast region as used by the Meteorological Service of Canada. All forecast region numbers are six digits with the first digit always zero.
5. TTTT — Purge time of the alert event (from exact time of issue)
    * In the format hhmm, using 15 minute increments up to one hour, using 30 minute increments up to six hours, and using hourly increments beyond six hours. Weekly and monthly tests sometimes have a 12-hour or greater purge time to assure users have an ample opportunity to verify reception of the test event messages; however; 15 minutes is more common, especially on NOAA Weather Radio's tests.
    * For short term events (like a tornado) this value could be set to 0000 (four zeros), which will purge the warning immediately after the message has been received. However, this is not typical, and FCC guidelines suggest a minimum of 15 minutes purge time.
    * **The purge time is not intended to coincide with the actual end of the event.** Longer events that may not end for days (like hurricanes) may have a purge time of only a few hours. That an event message has been purged does not indicate or imply that the threat has passed.
6. JJJHHMM — Exact time of issue, in UTC, (without time zone adjustments).
    * JJJ is the Ordinal date (day) of the year, with leading zeros
    * HHMM is the hours and minutes (24-hour format), in UTC, with leading zeros
7. LLLLLLLL — Eight-character station callsign identification, with "/" used instead of "–" (such as the first eight letters of a cable headend's location, WABC/FM for WABC-FM, KLOX/NWS for a weather radio station programmed from Los Angeles, or EC/GC/CA for a Weatheradio Canada station).

Each field of the header code is terminated by a dash character, including the station ID at the end; individual PSSCCC location numbers are also separated by dashes, with a plus (+) separating the last location from the purge time that follows it.

You can use the above protocol to encode custom EAS messages in the "Generate EAS from Custom Data" feature. Example image:
![image](https://user-images.githubusercontent.com/40973492/124539987-bfb12000-de48-11eb-9c00-8c3826a5b097.png)

## Contributing
If you want to contribute to the software, create a pull request. I will be happy to review and merge them!

## My social media
* [My YouTube EAS Mock Channel](https://www.youtube.com/channel/UCyWfIuvzwDRu6J9N9c0VP_Q/)
