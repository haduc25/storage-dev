import React from 'react';
import { 
  StyleSheet, 
  Text, 
  View,
  Button,
  TextInput,
  ScrollView,
  TouchableOpacity,
  Alert,
  Linking,
} from 'react-native';
import { BarCodeScanner } from 'expo-barcode-scanner';

//firebase
import { db } from '../Firebase/Config'
import { deleteDoc, doc, getDoc, setDoc } from 'firebase/firestore';



export default class Category extends React.Component {
  static navigationOptions = ({ navigation }) => {
    return {
        title: navigation.getParam('categoryName')
    };
  };
  
  //bar code
  constructor(props){
    super(props);
    this.state = {
      //bar code
      hasPermission: null,
      scanned: false,
      text: 'Vui lòng di chuyển đến mã cần quét!', //default
      // text: 'Camera đang tắt!', //cus
      textWaiting: 'Trống',

      //set scanner form
      formScanner: 'on', //default on

      //du lieu Doc Firebase
      // Storing User Data
      userDoc: null,
      // Update Text
      textDoc: '',

      //du lieu input Firebase
      // idcode
      textIDCode: '',
      // ten sp
      textTenSP: '',
      // gia nhap
      textGiaNhap: '',
      // gia nhap (thung)
      textGiaNhapThung: '',
      // gia ban
      textGiaBan: '',
      // gia ban (thung)
      textGiaBanThung: '',
      // han su dung
      textHSD: '',

      //set default Collection
      textCollection: 'TrangQuyenStore',


      //set for form
      formInsert: 'off',
      formSearch: 'off',
      




    };
  }

  
  hihi(){
    alert('kkk');
  }

  askForCameraPermission = () => {
  (async () => {
      const { status } = await BarCodeScanner.requestPermissionsAsync();
      this.setState({hasPermission: 'granted'});
  })()
  }

  
  handleBarCodeScanned = ({ type, data }) => {
    this.setState({scanned: true});
    this.setState({text: data});
    this.setState({textIDCode: data});
    // setText(data)
    alert("Type: " + type + "\nData: " + data)
    console.log('Type: ' + type + '\nData: ' + data)


    //ready for search
    this.Search3(type, data);
  }

  componentDidMount() {
    // {this.hihi()};
    {this.askForCameraPermission()};
  }

  //Cloud Firestore
  //search 
  Search2 = (value, merge) => {
    const myDoc = doc(db, this.state.textCollection, this.state.textIDCode)
    
    //console.log("value: " + this.state.textIDCode)
    getDoc(myDoc)
      // Handling Promises
      .then((snapshot) => {
        // MARK: Success
        if (!snapshot.exists) {
          // setUserDoc(snapshot.data())
          alert("No Doc Found")
        }
        else {
          this.setState({userDoc: snapshot.data()});
        }
      })
      .catch((error) => {
        // MARK: Failure
        alert(error.message)
        console.log(error.message)
      })
  }

  //search 
  Search3 = (type, data) => {
    console.log("Search3 running!");
    console.log('Type: ' + type + '\nData: ' + data)

    // this.state.userDoc != null &&
    // <Text style={{fontSize: 26}}>IDCode: {this.state.userDoc.IDCode}</Text>

    //<Text style={{fontSize: 26}}>IDCode: {this.state.userDoc.IDCode} {"\n"}Tên SP: {this.state.userDoc.TenSP} {"\n"}Giá: {this.state.userDoc.Gia} vnđ{"\n"}HSD: {this.state.userDoc.HanSD}</Text>
    

    //tesst
    // this.state.userDoc != null &&
    // this.setState({textTenSP: 'ahihi'});


    //start

    // MARK: Reading Doc
    // You can read what ever document by changing the collection and document path here

    if(data != '')
    {
      const myDoc = doc(db, this.state.textCollection, data)

          //console.log("value: " + this.state.textIDCode)
      getDoc(myDoc)
        // Handling Promises
        .then((snapshot) => {
          // MARK: Success
          if (!snapshot.exists) {
            // setUserDoc(snapshot.data())
            alert("No Doc Found")
          }
          else {
            this.setState({userDoc: snapshot.data()});
            console.log("Done");
            //this.setState.userDoc(snapshot.data());
            //this.addValueToTextBox;
          }
        })
        .catch((error) => {
          // MARK: Failure
          alert(error.message)
          console.log(error.message)
        })
    }












    
    

  }


  addValueToTextBox = () =>
  {
    //<Text style={{fontSize: 26}}>IDCode: {this.state.userDoc.IDCode} {"\n"}Tên SP: {this.state.userDoc.TenSP} {"\n"}Giá: {this.state.userDoc.Gia} vnđ{"\n"}HSD: {this.state.userDoc.HanSD}</Text>

    this.state.userDoc != null &&
    // this.setState({textIDCode: this.state.userDoc.IDCode});
    this.setState({textTenSP: this.state.userDoc.TenSP});
    this.setState({textGiaBan: this.state.userDoc.Gia});
    this.setState({textHSD: this.state.userDoc.HanSD});
  }

  // MARK: CRUD Functions
  Create2 = () => {
    


    // if(textIDCode == "" || textIDCode == " "){
    //   console.log("Error [01]: Không được phép để trống!");
    //   Alert.alert("Error [01]: ", "Không được phép để trống!");
    // }

    if(this.state.textTenSP == '' || this.state.textGiaNhap == '' || this.state.textGiaBan == '' || this.state.textGiaBanThung == '' || this.state.textGiaNhapThung == '' || this.state.textHSD == '')
    {
      console.log("Error [02]: Không được để trống !");
      alert("Error [02]: Không được để trống !");
    }else
    {
      //insert to firebase
      const myDoc = doc(db, this.state.textCollection, this.state.textIDCode)
      // Before that enable Firebase in Firebase Console

      // Your Document Goes Here
      const docData = {
        "IDCode": this.state.textIDCode,
        "TenSP": this.state.textTenSP,
        "GiaNhap": this.state.textGiaNhap,
        "GiaNhapThung": this.state.textGiaNhapThung,
        "GiaBanThung": this.state.textGiaBanThung,
        "Gia": this.state.textGiaBan,
        "HanSD": this.state.textHSD,
      }
      
      setDoc(myDoc, docData)
        // Handling Promises
        .then(() => {
          // MARK: Success
          Alert.alert("Thông báo!", "Đã thêm dữ liệu thành công.")
          //remove data
          this.isCleaner();
        })
        .catch((error) => {
          // MARK: Failure
          alert(error.message)
        })
    }
  }


 ClearValue()
 {  
  //  // ten sp
  //  this.setState({textTenSP: ''});
  //  // gia nhap
  //  this.setState({textGiaNhap: ''});
  //  // gia ban
  //  this.setState({textGiaBan: ''});
  //  // han su dung
  //  this.setState({textHSD: ''});

  //  {this.setState.userDoc != null}
  this.setState({userDoc: null});


   console.log("Clear done!");
   alert("Clear done!");

   //this.setState({userDoc: snapshot.data()});

   
 }

isReset()
{
  this.setState({userDoc: null});
  alert("*** did it.")
}



isInsert(){
  if(this.state.formInsert == 'off')
  {
    this.setState({formInsert: 'on'});
  }else{
    this.setState({formInsert: 'off'});
  }
}

isClearValue()
{
  Alert.alert(
    "Dọn dẹp?",
    "Tất cả dữ liệu vừa nhập sẽ bị xóa?",
    [
      // The "Yes" button
      {
        text: "OK",
        onPress: () => {
          this.setState({userDoc: null});
          this.setState({formInsert: 'off'});
          this.setState({formSearch: 'off'});
          this.setState({textIDCode: ''});
          this.setState({textTenSP: ''});
          this.setState({textGiaNhap: ''});
          this.setState({textGiaBan: ''});
          this.setState({textHSD: ''});
          this.setState({textGiaBanThung: ''});
          this.setState({textGiaNhapThung: ''});

        },
      },
      // The "No" button
      {
        text: "Hủy",
      },
    ]
  );

}


isOffScanner()
{
  if(this.state.formScanner == 'off')
  {
    this.setState({text: 'Vui lòng di chuyển đến mã cần quét!'});
    this.setState({formScanner: 'on'});
    Alert.alert('Thông báo','Camera đã bật');
  }else{
    this.setState({text: 'Camera đang tắt!'});
    this.setState({formScanner: 'off'});
    Alert.alert('Thông báo','Camera đã tắt');

  }
}

Update = () => {

  if(this.state.textTenSP == '' || this.state.textGiaNhap == '' || this.state.textGiaBan == '' || this.state.textHSD == '' || this.state.textGiaBanThung == '' || this.state.textGiaNhapThung == '')
  {
    console.log("Error [03]: Không được để trống !");
    alert("Error [03]: Không được để trống !");
  }else
  {
    Alert.alert(
      "Cập nhập lại dữ liệu?",
      "Hành động này có thể thay đổi dữ liệu và không thể phục hồi lại.",
      [
        // The "Yes" button
        {
          text: "Cập nhập",
          onPress: () => {
            //start    
              //insert to firebase
              const myDoc = doc(db, this.state.textCollection, this.state.textIDCode)
              // Before that enable Firebase in Firebase Console

              // Your Document Goes Here
              const docData = {
                "IDCode": this.state.textIDCode,
                "TenSP": this.state.textTenSP,
                "GiaNhap": this.state.textGiaNhap,
                "GiaNhapThung": this.state.textGiaNhapThung,
                "GiaBanThung": this.state.textGiaBanThung,
                "Gia": this.state.textGiaBan,
                "HanSD": this.state.textHSD,
              }

              setDoc(myDoc, docData)
                // Handling Promises
                .then(() => {
                  // MARK: Success
                  Alert.alert("Thông báo!", "Đã cập nhập dữ liệu thành công.")
                  //remove data
                  this.isCleaner();
                })
                .catch((error) => {
                  // MARK: Failure
                  alert(error.message)
                })
            //end
          },
        },
        // The "No" button
        // Does nothing but dismiss the dialog when tapped
        {
          text: "Hủy",
        },
      ]
    );

  }
}

Delete = () => {
  if(this.state.textIDCode == '')
  {
    console.log("Error [04]: Không được để trống !");
    alert("Error [04]: Không được để trống !");
  }else
  {
    Alert.alert(
      "Xóa dữ liệu?",
      "Hành động này có thể xóa dữ liệu và không thể phục hồi lại.",
      [
        // The "Yes" button
        {
          text: "Xóa",
          onPress: () => {
            //start
            const myDoc = doc(db, this.state.textCollection, this.state.textIDCode)

            deleteDoc(myDoc)
            // Handling Promises
            .then(() => {
              // MARK: Success
              Alert.alert("Thông báo!", "Đã xóa dữ liệu thành công.")
              this.isCleaner();
            })
            .catch((error) => {
              // MARK: Failure
              alert(error.message)
            })
            //end
          },
        },
        // The "No" button
        // Does nothing but dismiss the dialog when tapped
        {
          text: "Hủy",
        },
      ]
    );

  }
}


isFormSearch()
{
  if(this.state.formSearch == 'off')
  {
    this.setState({formSearch: 'on'});
  }else{
    this.setState({formSearch: 'off'});
  }
}

isCleaner()
{
  this.setState({textIDCode: null});
  this.setState({textTenSP: null});
  this.setState({textGiaNhap: null});
  this.setState({textGiaBan: null});
  this.setState({textHSD: null});
  this.setState({textGiaBanThung: null});
  this.setState({textGiaNhapThung: null});
}

  render(){
    // Return the View
    return (
      <View>
        <ScrollView style={{paddingTop: 50, paddingLeft: 16, paddingRight: 16}}>
          {this.state.formScanner != 'off' && <View style={styles.barcodebox}>
            <BarCodeScanner onBarCodeScanned={this.state.scanned ? undefined : this.handleBarCodeScanned} style={{ height: 400, width: 500 }} />
          </View>}
          <Text style={styles.maintext}>{this.state.text}</Text>
        
          {/* {this.state.scanned && <Button title={'Tiếp tục quét?'} onPress={() => this.setState({scanned: false})} color='tomato' />} */}
          {/* them disamble button va text */}

          {this.state.scanned && <TouchableOpacity style={styles.button} onPress={() => this.setState({scanned: false})}>
            <Text style={styles.text}>Tiếp tục quét?</Text>
          </TouchableOpacity>}



          <Text>{"\n"}</Text>
          <Text>{"\n"}</Text>



          <Text style={styles.textTitle}>THÔNG TIN CHI TIẾT SẢN PHẨM</Text>
          <Text>{"\n"}</Text>
          {/* textbox (scan show info)*/}
          {this.state.userDoc != null && <Text style={{fontSize: 16, paddingLeft: 10}}>IDCode: </Text>}
          {this.state.userDoc != null && <TextInput style={styles.inputStyle2} value={ this.state.userDoc.IDCode}></TextInput>}
          {this.state.userDoc != null && <Text style={{fontSize: 16, paddingLeft: 10}}>Tên SP: </Text>}
          {this.state.userDoc != null && <TextInput style={styles.inputStyle2} value={this.state.userDoc.TenSP}></TextInput>}
          {this.state.userDoc != null && <Text style={{fontSize: 16, paddingLeft: 10}}>Giá bán (lẻ): </Text>}
          {this.state.userDoc != null && <TextInput style={styles.inputStyle2} value={this.state.userDoc.Gia}></TextInput>}
          {this.state.userDoc != null && <Text style={{fontSize: 16, paddingLeft: 10}}>Giá bán (thùng): </Text>}
          {this.state.userDoc != null && <TextInput style={styles.inputStyle2} value={this.state.userDoc.GiaBanThung}></TextInput>}
          {this.state.userDoc != null && <Text style={{fontSize: 16, paddingLeft: 10}}>HSD: </Text>}
          {this.state.userDoc != null && <TextInput style={styles.inputStyle2} value={this.state.userDoc.HanSD}></TextInput>}

          


          <Text>{"\n"}</Text>
          <Text style={styles.textTitle}>Tính năng</Text>
          <Text>{"\n"}</Text>
          {/* camera */}
          <Button title='Bật/Tắt => [CAMERA]' onPress={() => this.isOffScanner()}></Button> 
          <Text>{"\n"}</Text>
          {/*click sửa*/}
          <Button title='Thêm, chỉnh sửa, Xóa => [Sản Phẩm]' onPress={() => this.isInsert()}></Button>
          {this.state.formInsert != "off" &&<Text>{"\n"}</Text>}
          {this.state.formInsert != "off" && <Text style={{fontSize: 16, paddingLeft: 10}}>IDCode: </Text>}
          {this.state.formInsert != "off" && <TextInput style={styles.inputStyle2} placeholder='Nhập IDCode' onChangeText={(textIDCode) => this.setState({textIDCode})} value={this.state.textIDCode}></TextInput>}
          {this.state.formInsert != "off" && <Text style={{fontSize: 16, paddingLeft: 10}}>Tên SP: </Text>}
          {this.state.formInsert != "off" && <TextInput style={styles.inputStyle2} placeholder='Nhập tên sản phẩm' onChangeText={(textTenSP) => this.setState({textTenSP})} value={this.state.textTenSP}></TextInput>}
          {this.state.formInsert != "off" && <Text style={{fontSize: 16, paddingLeft: 10}}>Giá nhập (lẻ): </Text>}
          {this.state.formInsert != "off" && <TextInput style={styles.inputStyle2} placeholder='Nhập giá nhập (lẻ)' onChangeText={(textGiaNhap) => this.setState({textGiaNhap})} value={this.state.textGiaNhap}></TextInput>}
          {this.state.formInsert != "off" && <Text style={{fontSize: 16, paddingLeft: 10}}>Giá bán (lẻ): </Text>}
          {this.state.formInsert != "off" && <TextInput style={styles.inputStyle2} placeholder='Nhập giá bán (lẻ)' onChangeText={(textGiaBan) => this.setState({textGiaBan})} value={this.state.textGiaBan}></TextInput>}
          {this.state.formInsert != "off" && <Text style={{fontSize: 16, paddingLeft: 10}}>Giá nhập (thùng): </Text>}
          {this.state.formInsert != "off" && <TextInput style={styles.inputStyle2} placeholder='Nhập giá nhập (thùng)' onChangeText={(textGiaNhapThung) => this.setState({textGiaNhapThung})} value={this.state.textGiaNhapThung}></TextInput>}
          {this.state.formInsert != "off" && <Text style={{fontSize: 16, paddingLeft: 10}}>Giá bán (thùng): </Text>}
          {this.state.formInsert != "off" && <TextInput style={styles.inputStyle2} placeholder='Nhập giá bán (thùng)' onChangeText={(textGiaBanThung) => this.setState({textGiaBanThung})} value={this.state.textGiaBanThung}></TextInput>}
          {this.state.formInsert != "off" && <Text style={{fontSize: 16, paddingLeft: 10}}>HSD: </Text>}
          {this.state.formInsert != "off" && <TextInput style={styles.inputStyle2} placeholder='Nhập hạn sử dụng' onChangeText={(textHSD) => this.setState({textHSD})} value={this.state.textHSD}></TextInput>}
          {this.state.formInsert != "off" &&<Text>{"\n"}</Text>}
          {this.state.formInsert != "off" && <Button title='Thêm sản phẩm [FIREBASE]' onPress={() => this.Create2()} disabled={this.state.textIDCode == ""}></Button>}
          {this.state.formInsert != "off" &&<Text>{"\n"}</Text>}
          {this.state.formInsert != "off" && <Button title='Chỉnh sửa sản phẩm [FIREBASE]' onPress={() => this.Update()} disabled={this.state.textIDCode == ""}></Button>}
          {this.state.formInsert != "off" &&<Text>{"\n"}</Text>}
          {this.state.formInsert != "off" && <Button title='Xóa sản phẩm [FIREBASE]' onPress={() => this.Delete()} disabled={this.state.textIDCode == ""}></Button>}
          <Text>{"\n"}</Text>
          {/* Tìm kiếm thủ công */}
          <Button title='Tìm kiếm thủ công => [IDCode]' onPress={() => this.isFormSearch()}></Button>
          {this.state.formSearch != "off" && <Text style={{fontSize: 16, paddingLeft: 10}}>IDCode: </Text>}
          {this.state.formSearch != "off" && <TextInput style={styles.inputStyle2} placeholder='Nhập IDCode' onChangeText={(textIDCode) => this.setState({textIDCode})} value={this.state.textIDCode}></TextInput>}
          {this.state.formSearch != "off" && <Button title='Tìm kiếm' onPress={() => this.Search2()} disabled={this.state.textIDCode == ""}></Button>}
          <Text>{"\n"}</Text>
          <Button title='Dọn dẹp => [CLEAN]' onPress={() => this.isClearValue()} disabled={this.state.textIDCode == ""} />
          <Text>{"\n"}</Text>
          <Text>{"\n"}</Text>
          <Text>{"\n"}</Text>
          <Text style={styles.textTitle}>Câu hỏi thường gặp</Text>
          <Text>{"\n"}</Text>
          <Text style={styles.txtQuesTitle}>1. Làm sao để "thêm, sửa, xóa" sản phẩm?</Text>
          <Text>- Thêm sản phẩm:</Text>
          <Text style={{paddingLeft: 5}}>
              + Để thêm sản phẩm cần quét mã vạch hoặc nhập mã vạch vào ô "IDCode", rồi tiến hành điền đầy đủ thông tin rồi chọn "Thêm sản phẩm [FIREBASE]".
          </Text>
          <Text>- Chỉnh sửa sản phẩm:</Text>
          <Text style={{paddingLeft: 5}}>
              + Để chỉnh sửa sản phẩm cần quét mã vạch hoặc nhập mã vạch vào ô "IDCode", rồi tiến hành sửa lại đầy đủ thông tin rồi chọn "Chỉnh sửa sản phẩm [FIREBASE]".
          </Text>
          <Text>- Xóa sản phẩm:</Text>
          <Text style={{paddingLeft: 5}}>
              + Để xóa sản phẩm cần quét mã vạch hoặc nhập mã vạch vào ô "IDCode", rồi chọn "Xóa sản phẩm [FIREBASE]".{"\n"}
              *Lưu ý: {"\n"}
              - Khi sửa hoặc xóa sản phẩm không thể hoàn tác.{"\n"}
              - Thêm, sửa, xóa bắt buộc cần có IDCode.
          </Text>
          <Text style={styles.txtQuesTitle}>2. Sử dụng "Tìm kiếm thủ công [IDCode]" như thế nào?</Text>
          <Text>- Tìm kiếm thủ công:</Text>
          <Text style={{paddingLeft: 5}}>
              + Sử sụng khi không thể quét mã vạch, rất đơn giản chỉ cần nhập "IDCode" và chọn "Tìm Kiếm".{"\n"}
              *Lưu ý: {"\n"}
              - Tìm kiếm thủ công bắt buộc cần có IDCode.
          </Text>
          <Text style={styles.txtQuesTitle}>3. Tác dụng của chức năng "Dọn dẹp [CLEAN]" là gì?</Text>
          <Text>- Dọn dẹp:</Text>
          <Text style={{paddingLeft: 5}}>
              + Giống như dọn dẹp "rác" chức năng này sẽ dọn dẹp dữ liệu đã nhập trước đó và đưa 1 số tính năng về trạng thái ban đầu.{"\n"}
          </Text>
          <Text>{"\n"}</Text>
          <Text>{"\n"}</Text>
          <Text>{"\n"}</Text>
          <Text style={styles.textTitle}>Trợ giúp & hỗ trợ</Text>
          <Text style={{color: 'blue', textAlign: 'center'}}onPress={() => Linking.openURL('https://www.facebook.com/haduc.25.09')}>Facebook: Hà Đức (facebook.com/haduc.25.09)</Text>
          <Text style={{color: 'blue', textAlign: 'center'}}onPress={() => Linking.openURL('https://console.firebase.google.com/u/0/project/trangquyen-shop/firestore/data/~2FTrangQuyenStore~2F8934707027874')}>Firebase (TrangQuyen - Shop)</Text>
          <Text>{"\n"}</Text>
          <Text>{"\n"}</Text>
          <Text style={{fontWeight: 'bold', textAlign:'center'}}>Copyright 2022 © HADUC25 | All rights reserved</Text>
          <Text>{"\n"}</Text>
          <Text>{"\n"}</Text>
        </ScrollView>
        
      </View>
    );
  }

}


const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },

  textTitle:{
    textAlign: 'center',
    borderBottomColor: '#333',
    borderBottomWidth: 0.5,
    color: '#333',
    fontSize: 18,
    fontWeight: 'bold',
    textTransform: 'uppercase',
    fontFamily: 'System',
  },
  maintext: {
    fontSize: 16,
    margin: 20,
    textAlign: 'center',
  },
  barcodebox: {
    // alignItems: 'center',
    // justifyContent: 'center',
    // height: 300,
    // width: 300,
    // overflow: 'hidden',
    // borderRadius: 30,
    // backgroundColor: 'tomato'

    // alignItems: 'center',
    // justifyContent: 'center',
    // paddingTop: 50,
    // height: 200,
    // paddingBottom: 100,
    // width: 397,
    // margin: 8,
    // // overflow: 'hidden',
    // borderRadius: 30,
    // backgroundColor: 'tomato',


    // alignItems: 'center',
    // justifyContent: 'center',
    // height: 200,
    // width: 300,
    // overflow: 'hidden',
    // borderRadius: 30,
    // backgroundColor: 'tomato'
    // width: 100,
    // height: 100,
    // borderRadius: 100/2,
    // justifyContent: 'center',
    // alignItems: 'center'

    alignItems: 'center',
    padding: 16,
    backgroundColor: '#fff',
    borderRadius: 10,
    shadowColor: '#000',
    shadowOpacity: 0.3,
    shadowRadius: 10,
    marginBottom: 16,
    shadowOffset: {width: 0, height: 0}
  },
  button:
  {
    // backgroundColor: '#FE434C',
    // alignItems: 'center',
    // justifyContent: 'center',
    // borderRadius: 10,
    // width: 240,
    // marginTop: 30,
    // height: 40,

    // alignItems: "center",
    // backgroundColor: "#DDDDDD",
    // padding: 10


    // alignItems: 'center',
    // justifyContent: 'center',
    // paddingVertical: 12,
    // paddingHorizontal: 32,
    // borderRadius: 4,
    // elevation: 3,
    // backgroundColor: '#512DA8',
    // width: 240,
    // height: 40,


    width: 380,
    height: 50,
    alignSelf: 'center',
    borderWidth: 1,
    borderColor: '#1c1c1c',
    borderRadius: 6,
    padding: 12,
  },

  text: {
    fontSize: 16,
    lineHeight: 21,
    fontWeight: 'bold',
    letterSpacing: 0.25,
    color: '#111',
    textAlign: 'center',
    
  },

  //text input
  inputStyle:{
    //1
    color: '#333',
    fontSize: 16,
    // lineHeight: 23,  
    // borderBottomColor: '#333',
    // borderBottomWidth: 0.5,
    fontFamily: 'System',

    //2
    height: 40,
    margin: 12,
    borderWidth: 1,
    padding: 10,







  },

  inputStyle2:{
    color: '#333',
    fontSize: 16,
    fontFamily: 'System',
    height: 40,
    margin: 12,
    borderWidth: 1,
    padding: 10,
  },

  //text question
  txtQuesTitle:
  {
    fontWeight: 'bold',

  },

});
