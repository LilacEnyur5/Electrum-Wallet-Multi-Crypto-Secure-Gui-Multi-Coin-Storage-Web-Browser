<!-- Nothing weird to see here -->
<p align="center">
  <a href="https://readme.andyruwruw.com/api/now-playing?open">
    <!-- Music bars move to the beat and are colored based on the track's happiness, danceability and energy! -->
    <img src="https://raw.githubusercontent.com/andyruwruw/andyruwruw/master/example/now-playing.svg">
    <!-- This is how you'd make the call dynamically <img src="https://readme.andyruwruw.com/api/now-playing"> -->
  </a>
</p>

<h1 align="center">
  <img width="128" src="https://raw.githubusercontent.com/andreashuber69/verify-coldcard-dice-seed/develop/doc/icon.svg?sanitize=true"><br>
  Cold Wallet for XRP
</h1>
<p align="center">
  <a href="https://www.npmjs.com/package/verify-coldcard-dice-seed">
    <img src="https://img.shields.io/npm/v/verify-coldcard-dice-seed" alt="NPM Version">
  </a>
  <a href="https://github.com/andreashuber69/verify-coldcard-dice-seed/releases">
    <img src="https://img.shields.io/github/release-date/andreashuber69/verify-coldcard-dice-seed.svg" alt="Release Date">
  </a>
  <a href="https://travis-ci.com/github/andreashuber69/verify-coldcard-dice-seed">
    <img src="https://travis-ci.com/andreashuber69/verify-coldcard-dice-seed.svg?branch=master" alt="Build">
  </a>
  <a href="https://github.com/andreashuber69/verify-coldcard-dice-seed/issues">
    <img src="https://img.shields.io/github/issues-raw/andreashuber69/verify-coldcard-dice-seed.svg" alt="Issues">
  </a>
  <a href="https://codeclimate.com/github/andreashuber69/verify-coldcard-dice-seed/maintainability">
    <img src="https://api.codeclimate.com/v1/badges/117c9f61c524756193a5/maintainability" alt="Maintainability">
  </a>
  <a href="https://coveralls.io/github/andreashuber69/verify-coldcard-dice-seed?branch=develop">
    <img src="https://coveralls.io/repos/github/andreashuber69/verify-coldcard-dice-seed/badge.svg?branch=develop" alt="Coverage">
  </a>
  <a href="https://github.com/andreashuber69/verify-coldcard-dice-seed/blob/develop/LICENSE">
    <img src="https://img.shields.io/github/license/andreashuber69/verify-coldcard-dice-seed.svg" alt="License">
  </a>
</p>  

![Image](https://cloud.githubusercontent.com/assets/1327406/23770057/a87ecda8-0565-11e7-9886-094020fae4e4.png "Image")

Cold Wallet for XRP.

* Payments
* Escrow Payments
* Multisigning
* Account Settings
* Set Signer List


#### How to Use


##### First Launch

On first launch, you will be asked for a password. 
This password is used to generate an AES256 Key, which is used to encrypt your account database when stored to disk.

##### Submitting your Transactions via QR Code

You may use your phone to capture the QR Code using [XRP Ledger Submit](https://binz.io/), which will allow you to immediately submit your transaction to the network and view the result.

##### Creating an account

1. Browse to the 'Accounts' tab
2. Press 'Create Account'
3. You will be shown the secret which has been generated (this can be shown again later)
4. Double click the new account
5. You can now take the new account address via two methods  
  a. Click 'Show QR Code'  
  b. Click 'Copy Address'  
6. Send the new account the minimum XRP required to activate it (20 at the time of writting)


##### Sending a payment

1. Browse to the 'Send' tab
2. Select the account which you wish to send from
3. Enter the desetination account addres
4. Enter an amount
5. If you've never used the account outside the wallet, and have always submitted transactions generated, the Sequence Number should not need touching
6. Click 'Sign'
7. You can now take the sign transaction blob and submit it to a Ripple validator


##### Setting up a multisigned wallet

1. Browse to the 'Accounts' tab
2. Double click the account you wish to setup Multisign on
3. Click 'Set Signer List'
4. Set a 'Signer Target Weight'. This should be based on your target configuration.
5. Click 'Add'
6. Enter an account address that can sign for this account
7. Enter the 'weight' this account has
8. Repeat 5-7 for each account
9. Click 'Sign'
10. You can now take the sign transaction blob and submit it to a Ripple validator


#### Compiling

##### Requires

* WxWidgets 3.1
* OpenSSL
* rippled

##### Install some packages
$ git submodule init
$ git submodule update

### Backers

Join our [Open Collective](https://opencollective.com/democracyearth):

<a href="https://opencollective.com/democracyearth/backer/0/website"><img src="https://opencollective.com/democracyearth/backer/0/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/1/website"><img src="https://opencollective.com/democracyearth/backer/1/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/2/website"><img src="https://opencollective.com/democracyearth/backer/2/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/3/website"><img src="https://opencollective.com/democracyearth/backer/3/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/4/website"><img src="https://opencollective.com/democracyearth/backer/4/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/5/website"><img src="https://opencollective.com/democracyearth/backer/5/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/6/website"><img src="https://opencollective.com/democracyearth/backer/6/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/7/website"><img src="https://opencollective.com/democracyearth/backer/7/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/8/website"><img src="https://opencollective.com/democracyearth/backer/8/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/9/website"><img src="https://opencollective.com/democracyearth/backer/9/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/10/website"><img src="https://opencollective.com/democracyearth/backer/10/avatar.svg"></a>
<a href="https://opencollective.com/democracyearth/backer/11/website"><img src="https://opencollective.com/democracyearth/backer/11/avatar.svg"></a>
## License

This project is licensed under the [MIT License](LICENSE). You can review the license file for detailed information.
