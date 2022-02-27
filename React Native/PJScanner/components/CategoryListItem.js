import React from 'react';
import { 
  StyleSheet, 
  Text, 
  View,
  Image,
  TouchableOpacity,
  TouchableOpacityBase,
} from 'react-native';
import NameImage from  '../image/isGirl.jpg';




export default function CategoryListItem(props) {
  const {category, onPress} = props; //gan category = props (giong gan props = category)

    
  return(
    <TouchableOpacity 
      activeOpacity={0.5} 
      // onPress={() => 
      //   {
      //     Alert.alert('Clicked','click cai cc?');
      //     console.log('Clicked');
      //   }
      // }
      onPress={onPress}
    >
      <View style={styles.container}>
        <Text style={styles.title}>{category.name}</Text>
        <Image style={styles.categoryImage} source={NameImage}/>
      </View>
    </TouchableOpacity>
  );
}

const styles = StyleSheet.create({
    container: {
      alignItems: 'center',
      padding: 16,
      backgroundColor: '#fff',
      borderRadius: 4,
      shadowColor: '#000',
      shadowOpacity: 0.3,
      shadowRadius: 10,
      marginBottom: 16,
      shadowOffset: {width: 0, height: 0}
    },

    categoryImage:{
        width: 200,
        height: 200
    },

    title:{
      textTransform: 'uppercase',
      marginBottom: 8,
      fontWeight: '700',
      color: '#121212'
    }



  });